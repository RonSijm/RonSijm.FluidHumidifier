using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECRServiceAccessStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ElastiCacheStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.LoadBalancerStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.PUMUsersStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;
using Humidifier.Helpers;
using RonSijm.FluidHumidifier.VCDM.Helpers;
using RonSijm.FluidHumidifier.VCDM.Scripts;
using RonSijm.FluidHumidifier.VCDM.Stacks;
using System.Text;
using AppleStore.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CircleCIUserStack;
using AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseCrossRegionBackupStack;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;

public class OTAPEnvironmentComposer(
    GithubUserStackComposer githubUserStackComposer,
    CloudformationResourcesStackComposer cloudformationResourcesStackComposer,
    SlackLoggerStackComposer slackLoggerStackComposer,
    ERCServiceAccessStackComposer ecrServiceAccessStackComposer,
    VPCInfrastructureStackComposer vpcInfrastructureStackComposer,
    ElastiCacheStackComposer elastiCacheStackComposer,
    CrossRegionBackupStackComposer crossRegionBackupStackComposer,
    DatabaseStackComposer databaseStackComposer,
    LoadBalancerStackComposer loadBalancerStackComposer,
    ECSServiceStackComposer ecsServiceStackComposer,
    VCDMLoggingStackComposer vcdmLoggingStackComposer,
    GuardDutyScriptFactory guardDutyScriptFactory,
    PUMUsersStackComposer pumUsersStackComposer,
    CircleCIUserStackComposer circleCIUserStackComposer,
    DecoratorOrchestrator decoratorOrchestrator) : BaseEnvironmentComposer<OTAPEnvironmentConfig>(decoratorOrchestrator)
{
    protected override EnvironmentOutputResult Create(OTAPEnvironmentConfig config)
    {
        var result = new EnvironmentOutputResult
        {
            Environment = config.Environment,
            RegionName = AWSConfigSettings.DefaultRegion,
        };

        var scriptsBasePath = $"Cloud Formation\\Scripts\\";
        var allScriptsBasePath = $"{scriptsBasePath}1 - All\\";

        LoggingBucketNameFactory.ConceptName = "applestore";

        // Github User Stack
        var githubUserStackConfig = new GithubUserStackConfig
        {
            OTAPNeededDeployPermissions.EC2Permissions,
            OTAPNeededDeployPermissions.ElasticachePermissions,
            OTAPNeededDeployPermissions.IAMPermissions,
            OTAPNeededDeployPermissions.RDSPermissions,
            OTAPNeededDeployPermissions.RDSUpgradePermissions,
            OTAPNeededDeployPermissions.S3Permissions,
            OTAPNeededDeployPermissions.ECSPermissions,
            OTAPNeededDeployPermissions.LoadBalancerPermissions
        };

        // Cross Region Backup Stack - needs to be before the database stack
        // Is in a different region, so we add it on top, so we only have to re-auth once
        var crossRegionBackupStackResult = result.Add(() => crossRegionBackupStackComposer.Create(new CrossRegionBackupStackConfig()),
            $"{scriptsBasePath}2 - {AWSConfigSettings.BackupRegionName}\\1 - {AWSConfigSettings.BackupRegionName} Database Backup\\{config.Environment.EnvironmentName}"
        );


        githubUserStackConfig.UseLeastPrivilege = false;

        var githubUserStack = githubUserStackComposer.Create(githubUserStackConfig);

        var githubResources = result.Add(githubUserStack, $"Cloud Formation\\Scripts\\1 - All\\4 - Create CloudFormation {githubUserStack.Stack.Name} Stack\\{config.Environment.EnvironmentName}");

        var cloudformationResourcesConfig = new CloudformationResourcesConfig();

        var cloudFormationResourcesStack = result.Add(() => cloudformationResourcesStackComposer.Create(cloudformationResourcesConfig), $"Cloud Formation\\Scripts\\1 - All\\5 - Cloudformation Resources Stack\\{config.Environment.EnvironmentName}");

        result.Add(() => slackLoggerStackComposer.Create(new SlackLoggerStackConfig
        {
            Import = new List<ExportModel> { cloudFormationResourcesStack.Export, githubResources.Export }
        }),
            $"Cloud Formation\\Scripts\\1 - All\\6 - Create Lambda Logger Stack\\{config.Environment.EnvironmentName}"
        );

        result.Add(() => vcdmLoggingStackComposer.Create(new()));

        var serviceAccessStack = result.Add(() => ecrServiceAccessStackComposer.Create(new()
        {
            AssetAccountId = config.AssetAccountId
        }));

        var infraStructure = result.Add(() => vpcInfrastructureStackComposer.Create(new VPCInfrastructureConfig()));

        result.Add(() => elastiCacheStackComposer.Create(new() { Import = infraStructure.Export }));

        // Resolve the password during deployment; no credentials are stored in the sample.
        var databasePassword = $"{{{{resolve:secretsmanager:example/{ResourceConfigSettings.ConceptNameLower}/{config.Environment.EnvironmentName}/database:SecretString:password}}}}";

        result.Add(() => databaseStackComposer.Create(new()
        {
            Import = new List<ExportModel> 
            {
                infraStructure.Export,
                cloudFormationResourcesStack.Export, // Needs notification topic to send messages about db backups
                crossRegionBackupStackResult.Export // Needs to know where backup vault is.
            },
            DatabaseMasterUsername = $"root_user_{config.Environment.EnvironmentName}",
            DatabaseMasterUserPassword = databasePassword
        }));

        var loadBalancer = result.Add(() => loadBalancerStackComposer.Create(new() { Import = infraStructure.Export }));

        result.Add(() => ecsServiceStackComposer.Create(new()
        {
            Import = new List<ExportModel> {
                infraStructure.Export, // Needs SecurityGroupAndSubnets
                serviceAccessStack.Export, // Needs Service Role
                cloudFormationResourcesStack.Export, // Needs S3 Bucket for Config,
                loadBalancer.Export // Needs LoadBalancer Target Arm
            },
            AssetsAccountId = config.AssetAccountId,
            CreateServices = true,
        }));

        result.Add(7, "Enable GuardDuty", () => guardDutyScriptFactory.Create(new GuardDutyScriptFactoryConfig()
        {
            KMSKeyRegion = AWSConfigSettings.DefaultRegion,
            Regions = AWSRegionList.DefaultEnabledRegions.ToList(),
            ConceptName = LoggingBucketNameFactory.ConceptName
        }), $"Cloud Formation\\Scripts\\1 - All\\7 - Enable GuardDuty\\{config.Environment.EnvironmentName}");

        result.Add(() => pumUsersStackComposer.Create(new()));

        result.Add(() => circleCIUserStackComposer.Create(new CircleCIUserStackConfig
            {
                Import = new List<ExportModel> { githubResources.Export },
            }),
            $"{allScriptsBasePath}9 - Create CircleCI User\\{config.Environment.EnvironmentName}"
        );

        return result;
    }
}
