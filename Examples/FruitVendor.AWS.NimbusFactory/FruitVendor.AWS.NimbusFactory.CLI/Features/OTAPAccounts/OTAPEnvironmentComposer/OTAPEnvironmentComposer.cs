using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using FruitVendor.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.CloudformationResourcesStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.GithubUserStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.AllAccounts.StacksForAllAccounts.SlackLoggingStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ElasticBeanstalkStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.FrontendStack;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ImageProcessor;
using FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.VPCInfrastructureStack;
using RonSijm.FluidHumidifier.VCDM.Helpers;
using System.Text;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.OTAPEnvironmentComposer;

public class OTAPEnvironmentComposer(
    GithubUserStackComposer githubUserStackComposer,
    CloudformationResourcesStackComposer cloudformationResourcesStackComposer,
    SlackLoggerStackComposer slackLoggerStackComposer,
    VPCInfrastructureStackComposer vpcInfrastructureStackComposer,
    DatabaseStackComposer databaseStackComposer,
    ElasticBeanstalkStackComposer elasticBeanstalkStackComposer,
    FrontendStackComposer frontendStackComposer,
    ImageProcessorStackComposer imageProcessorStackComposer,
    DecoratorOrchestrator decoratorOrchestrator) : BaseEnvironmentComposer<OTAPEnvironmentConfig>(decoratorOrchestrator)
{
    protected override EnvironmentOutputResult Create(OTAPEnvironmentConfig config)
    {
        var result = new EnvironmentOutputResult
        {
            Environment = config.Environment,
            RegionName = AWSConfigSettings.RegionName,
        };

        var scriptsBasePath = $"Cloud Formation\\Environments\\prod\\";

        LoggingBucketNameFactory.ConceptName = "fruitvendor";

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

        githubUserStackConfig.RepoRoot = "FruitVendor";

        githubUserStackConfig.UseLeastPrivilege = false;

        var githubUserStack = githubUserStackComposer.Create(githubUserStackConfig);

        var githubResources = result.Add(githubUserStack, $"Cloud Formation\\Environments\\{config.Environment.EnvironmentName}");

        var cloudformationResourcesConfig = new CloudformationResourcesConfig();

        var cloudFormationResourcesStack = result.Add(() => cloudformationResourcesStackComposer.Create(cloudformationResourcesConfig), $"Cloud Formation\\Environments\\{config.Environment.EnvironmentName}");

        result.Add(() => slackLoggerStackComposer.Create(new SlackLoggerStackConfig
        {
            Import = new List<ExportModel> { cloudFormationResourcesStack.Export, githubResources.Export }
        }),
            $"Cloud Formation\\Environments\\{config.Environment.EnvironmentName}"
        );

        var infraStructure = result.Add(() => vpcInfrastructureStackComposer.Create(new VPCInfrastructureConfig()));

        // Resolve the password during deployment; no credentials are stored in the sample.
        var databasePassword = $"{{{{resolve:secretsmanager:example/{ResourceConfigSettings.ConceptNameLower}/{config.Environment.EnvironmentName}/database:SecretString:password}}}}";

        result.Add(() => databaseStackComposer.Create(new()
        {
            Import = new List<ExportModel>
            {
                infraStructure.Export,
                cloudFormationResourcesStack.Export // Needs notification topic to send messages about db backups
            },
            DatabaseMasterUsername = $"root_user_{config.Environment.EnvironmentName.Replace("-", "_")}",
            DatabaseMasterUserPassword = databasePassword
        }));

        // Create Elastic Beanstalk stack
        result.Add(() => elasticBeanstalkStackComposer.Create(new ElasticBeanstalkStackConfig
        {
            InstanceType = "t3.small",
            MinInstances = 1,
            MaxInstances = 2,
            EnableLoadBalancer = true,
            Import = new List<ExportModel>()
            {
                infraStructure.Export,
            }
            //VPCId = FFn.ImportValue(infraStructure.Export.ExportValue),
            //Subnets = new List<string> { FFn.ImportValue(infraStructure.Export.ExportValue) },
            //SecurityGroups = new List<string> { FFn.ImportValue(infraStructure.Export.ExportValue) },
            //EnvironmentVariables = new Dictionary<string, string>
            //{
            //    { "ASPNETCORE_ENVIRONMENT", config.Environment.EnvironmentName },
            //    { "ConnectionStrings__Default", "<resolve a connection string from Secrets Manager>" }
            //}
        }));

        result.Add(() => frontendStackComposer.Create(new FrontendStackConfig()
        {
        }));

        result.Add(() => imageProcessorStackComposer.Create(new ImageProcessorStackConfig()
        {
        }));

        return result;
    }
}
