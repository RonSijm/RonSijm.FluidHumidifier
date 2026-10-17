using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using Humidifier.Helpers;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ElasticBeanstalkStack;

public class ElasticBeanstalkStackConfig
{
    public ElasticBeanstalkStackConfig()
    {
        VPCId = new WithFallback<dynamic>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.VPC).ImportValue());

        Subnets = new WithFallback<dynamic>(() => (new List<dynamic>
        {
            Fn.ImportValue($"{ResourceConfigSettings.BackendName}SubnetAZA"),
            Fn.ImportValue($"{ResourceConfigSettings.BackendName}SubnetAZB"),
            Fn.ImportValue($"{ResourceConfigSettings.BackendName}SubnetAZC"),
        }).ToArray());

        LoadBalancerSubnets = new WithFallback<dynamic>(() => (new List<dynamic>
        {
            Fn.ImportValue($"{ResourceConfigSettings.ServiceName}LBSubnetAZA"),
            Fn.ImportValue($"{ResourceConfigSettings.ServiceName}LBSubnetAZB"),
            Fn.ImportValue($"{ResourceConfigSettings.ServiceName}LBSubnetAZC"),
        }).ToArray());

        //SecurityGroups = new WithFallback<dynamic>(() => new List<dynamic>
        //{
        //    Import?.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.Contains(ResourceConfigSettings.BackendName + "-SecurityGroup")).ImportValue()
        //});
    }

    public ImportModel Import { private get; set; }
    public string SolutionStackName { get; set; } = "64bit Windows Server 2019 v2.18.0 running IIS 10.0";
    public string InstanceType { get; set; } = "t3.small";
    public int MinInstances { get; set; } = 1;
    public int MaxInstances { get; set; } = 2;
    public bool EnableLoadBalancer { get; set; } = true;
    public WithFallback<dynamic> SecurityGroups { get; set; }
    public WithFallback<dynamic> Subnets { get; set; }
    public WithFallback<dynamic> LoadBalancerSubnets { get; set; }
    public WithFallback<dynamic> VPCId { get; set; }
    public Dictionary<string, string> EnvironmentVariables { get; set; } = new();
} 