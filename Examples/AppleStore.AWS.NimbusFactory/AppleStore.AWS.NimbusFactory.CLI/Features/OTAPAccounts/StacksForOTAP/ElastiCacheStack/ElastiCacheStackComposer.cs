namespace AppleStore.AWS.NimbusFactory.CLI.Features.OTAPAccounts.StacksForOTAP.ElastiCacheStack;

public class ElastiCacheStackComposer : BaseStackComposer<ElastiCacheStackConfig>
{
    public override StackCreateResult Create(ElastiCacheStackConfig config)
    {
        var environmentFactory = CreateEnvironmentFactory();

        var stack = environmentFactory
            .AddStack(ResourceConfigSettings.RedisName);

        var replicationGroupFactory = stack.WithReplicationGroup($"{ResourceConfigSettings.ConceptName} {ResourceConfigSettings.RedisName} Cluster", replicationGroup =>
        {
            replicationGroup.AutomaticFailoverEnabled = true;
            replicationGroup.NumCacheClusters = 3;
            replicationGroup.CacheNodeType = "cache.t3.micro";
            replicationGroup.Engine = "redis";
            replicationGroup.EngineVersion = "7.1";
            replicationGroup.SnapshotRetentionLimit = Fn.Literal("0");
            replicationGroup.SnapshotWindow = "06:00-07:00";
            replicationGroup.TransitEncryptionEnabled = true;
            replicationGroup.AtRestEncryptionEnabled = true;
            replicationGroup.MultiAZEnabled = true;
            replicationGroup.CacheSubnetGroupName = config.Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.ElastiCache.SubnetGroup).ImportValue();
            replicationGroup.SecurityGroupIds = new List<Union<string, BaseFunction>> { config.Import.Single(x => x.Result.AWSTypeName == Humidifier.AWS.EC2.SecurityGroup && x.Result.GivenName.GetLiteral().Contains(ResourceConfigSettings.RedisName)).ImportValue() };
        });

        stack.WithRecordSet(record =>
        {
            record.HostedZoneName = $"{Environment.EnvironmentName}-applestore.example.";
            record.Type = "CNAME";
            record.Name = $"redis.{Environment.EnvironmentName}-applestore.example";
            record.TTL = Fn.Literal(300);
            record.ResourceRecords = new List<Union<string, BaseFunction>>() { FFn.FFnGetAtt(replicationGroupFactory, "PrimaryEndPoint.Address") };
        });

        var stackResult = environmentFactory.Build().First();

        var result = new StackCreateResult
        {
            Stack = stackResult
        };

        return result;
    }
}