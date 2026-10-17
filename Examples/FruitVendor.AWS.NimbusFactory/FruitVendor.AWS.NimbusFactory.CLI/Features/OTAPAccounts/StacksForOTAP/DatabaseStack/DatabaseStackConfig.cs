using FruitVendor.AWS.NimbusFactory.CLI.Core.Config;
using Humidifier.Helpers;

namespace FruitVendor.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public class DatabaseStackConfig
{
    public DatabaseStackConfig()
    {
        VpcSecurityGroupIds = new WithFallback<dynamic>(() => new List<dynamic> { Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.Contains(ResourceConfigSettings.DatabaseGroupName)).ImportValue() });
        DBSubnetGroupName = new WithFallback<dynamic>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.RDS.DBSubnetGroup).ImportValue());
        SlackLoggingTopic = new WithFallback<List<dynamic>>(() => [Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.SNS.Topic).ImportValue()]);
    }

    public ImportModel Import { private get; set; }

    public dynamic DatabaseMasterUsername { get; set; }
    public dynamic DatabaseMasterUserPassword { get; set; }

    public WithFallback<dynamic> VpcSecurityGroupIds { get; set; }
    public WithFallback<dynamic> DBSubnetGroupName { get; set; }
    public WithFallback<List<dynamic>> SlackLoggingTopic { get; set; }
}