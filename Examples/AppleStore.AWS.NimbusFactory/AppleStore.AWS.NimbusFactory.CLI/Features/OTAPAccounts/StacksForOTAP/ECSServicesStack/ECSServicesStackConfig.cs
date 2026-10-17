using Humidifier.Helpers;
using RonSijm.FluidHumidifier.Factories.ElasticLoadBalancingV2;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ECSServicesStack;

public class ECSServiceStackConfig
{
    public ImportModel Import { private get; set; }

    public string AssetsAccountId { get; set; }
    public bool CreateServices { get; set; }

    public WithFallback<dynamic> LoadBalancer { get; set; }
    public WithFallback<RoleFactory> TaskRole { get; set; }
    public WithFallback<dynamic> DockerSubnets { get; set; }
    public WithFallback<dynamic> SecurityGroups { get; set; }

    public ECSServiceStackConfig()
    {
        LoadBalancer = new WithFallback<dynamic>(() =>
        {
            var targetGroupFactory = Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.ElasticLoadBalancingV2.TargetGroup) as TargetGroupFactory;
            return targetGroupFactory.ImportValue();
        });

        TaskRole = new WithFallback<RoleFactory>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.IAM.Role && x.Result.ResourceName.Contains("AccessRole")) as RoleFactory);
        DockerSubnets = new WithFallback<dynamic>(() => new List<dynamic>
        {
            Fn.ImportValue($"{ResourceConfigSettings.DockerName}SubnetAZA"),
            Fn.ImportValue($"{ResourceConfigSettings.DockerName}SubnetAZB"),
            Fn.ImportValue($"{ResourceConfigSettings.DockerName}SubnetAZC"),
        });

        SecurityGroups = new WithFallback<dynamic>(() => new List<dynamic>
        {
            Import?.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.Contains(ResourceConfigSettings.DockerName + "-SecurityGroup")).ImportValue()
        });
    }
}