using Humidifier.Helpers;

namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.DatabaseStack;

public class DatabaseStackConfig
{
    public DatabaseStackConfig()
    {
        VpcSecurityGroupIds = new WithFallback<StringListValue>(() => new List<Union<string, BaseFunction>> { Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.GetLiteral().Contains(ResourceConfigSettings.DatabaseGroupName)).ImportValue() });
        DBSubnetGroupName = new WithFallback<StringValue>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.RDS.DBSubnetGroup).ImportValue());
        BackupDestinationVault = new WithFallback<StringValue>(() => Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.Backup.BackupVault).ImportValue());
        SlackLoggingTopic = new WithFallback<StringListValue>(() => new Union<string, BaseFunction>[] { Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.SNS.Topic).ImportValue() });
    }

    public ImportModel Import { private get; set; }

    public StringValue DatabaseMasterUsername { get; set; }
    public StringValue DatabaseMasterUserPassword { get; set; }

    public WithFallback<StringListValue> VpcSecurityGroupIds { get; set; }
    public WithFallback<StringValue> DBSubnetGroupName { get; set; }
    public WithFallback<StringListValue> SlackLoggingTopic { get; set; }
    public WithFallback<StringValue> BackupDestinationVault { get; set; }
}