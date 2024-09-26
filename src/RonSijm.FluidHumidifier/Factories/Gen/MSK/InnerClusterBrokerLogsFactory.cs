// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterBrokerLogsFactory(Action<Humidifier.MSK.ClusterTypes.BrokerLogs> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.BrokerLogs>
{

    internal InnerClusterS3Factory S3Factory { get; set; }

    internal InnerClusterFirehoseFactory FirehoseFactory { get; set; }

    internal InnerClusterCloudWatchLogsFactory CloudWatchLogsFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.BrokerLogs Create()
    {
        var brokerLogsResult = CreateBrokerLogs();
        factoryAction?.Invoke(brokerLogsResult);

        return brokerLogsResult;
    }

    private Humidifier.MSK.ClusterTypes.BrokerLogs CreateBrokerLogs()
    {
        var brokerLogsResult = new Humidifier.MSK.ClusterTypes.BrokerLogs();

        return brokerLogsResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.BrokerLogs result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
        result.Firehose ??= FirehoseFactory?.Build();
        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterBrokerLogsFactoryExtensions
{
    public static CombinedResult<InnerClusterBrokerLogsFactory, InnerClusterS3Factory> WithS3(this InnerClusterBrokerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerClusterS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerClusterBrokerLogsFactory, InnerClusterFirehoseFactory> WithFirehose(this InnerClusterBrokerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null)
    {
        parentFactory.FirehoseFactory = new InnerClusterFirehoseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FirehoseFactory);
    }

    public static CombinedResult<InnerClusterBrokerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs(this InnerClusterBrokerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerClusterCloudWatchLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, InnerClusterS3Factory> WithS3<T1>(this CombinedResult<InnerClusterBrokerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, InnerClusterS3Factory> WithS3<T1>(this CombinedResult<T1, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, InnerClusterFirehoseFactory> WithFirehose<T1>(this CombinedResult<InnerClusterBrokerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1>(this CombinedResult<T1, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerClusterBrokerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerClusterBrokerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterBrokerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterBrokerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterBrokerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterBrokerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction));
}
