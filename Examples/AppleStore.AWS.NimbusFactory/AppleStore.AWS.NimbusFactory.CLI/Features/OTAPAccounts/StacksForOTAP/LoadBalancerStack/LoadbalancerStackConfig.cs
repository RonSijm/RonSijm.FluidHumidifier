using Humidifier.Helpers;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.LoadBalancerStack;

public class LoadbalancerStackConfig
{
    public LoadbalancerStackConfig()
    {
        LoadBalancerSecurityGroups = new WithFallback<dynamic>(() =>
        {
            var importedSecurityGroup = Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.Contains(ResourceConfigSettings.LoadBalancerName));

            var securityGroups = new List<dynamic>
            {
                importedSecurityGroup.ImportValue()
            };

            return securityGroups;
        });
    }

    private dynamic _loadBalancerSubnets;

    public ImportModel Import { private get; set; }

    public WithFallback<dynamic> LoadBalancerSecurityGroups { get; set; }

    public dynamic LoadBalancerSubnets
    {
        get
        {
            if (_loadBalancerSubnets != null)
            {
                return _loadBalancerSubnets;
            }

            var name = ResourceConfigSettings.LoadBalancerName.Replace("-", string.Empty);

            var subnets = new List<dynamic>
            {
                Fn.ImportValue($"{name}SubnetAZA"),
                Fn.ImportValue($"{name}SubnetAZB"),
                Fn.ImportValue($"{name}SubnetAZC"),
            };

            return subnets;
        }
        set => _loadBalancerSubnets = value;
    }

    private dynamic _vpcId;

    public dynamic VpcId
    {
        get
        {
            if (_vpcId != null)
            {
                return _vpcId;
            }

            var importedVPC = Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.VPC);
            return importedVPC.ImportValue();
        }
        set => _vpcId = value;
    }
}

public static class CertificateRetriever
{
    public static dynamic GetCertificateArnFromRegion(string environmentName)
    {
        if (environmentName == "dev")
        {
            return "arn:aws:acm:eu-central-1:333333333333:certificate/00000000-0000-0000-0000-000000000004";
        }

        if (environmentName == "staging")
        {
            return "arn:aws:acm:eu-central-1:444444444444:certificate/00000000-0000-0000-0000-000000000005";
        }

        if (environmentName == "prod")
        {
            return "arn:aws:acm:eu-central-1:666666666666:certificate/00000000-0000-0000-0000-000000000006";
        }

        if (environmentName == "assets")
        {
            return "arn:aws:acm:us-east-1:111111111111:certificate/00000000-0000-0000-0000-000000000007";
        }

        throw new NotImplementedException();
    }

    public static dynamic GetCertificateArnFromGlobal(string environmentName)
    {
        // TODO
        if (environmentName == "dev")
        {
            return "arn:aws:acm:us-east-1:333333333333:certificate/00000000-0000-0000-0000-000000000008";
        }

        if (environmentName == "staging")
        {
            return "arn:aws:acm:us-east-1:444444444444:certificate/00000000-0000-0000-0000-000000000009";
        }

        if (environmentName == "prod")
        {
            return "arn:aws:acm:us-east-1:666666666666:certificate/00000000-0000-0000-0000-000000000010";
        }

        if (environmentName == "assets")
        {
            return "arn:aws:acm:us-east-1:111111111111:certificate/00000000-0000-0000-0000-000000000007";
        }

        throw new NotImplementedException();
    }
}