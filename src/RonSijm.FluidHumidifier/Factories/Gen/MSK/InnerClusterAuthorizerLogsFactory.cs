// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerClusterAuthorizerLogsFactory(Action<Humidifier.MSK.ClusterTypes.AuthorizerLogs> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ClusterTypes.AuthorizerLogs>
{

    internal InnerClusterS3Factory S3Factory { get; set; }

    internal InnerClusterFirehoseFactory FirehoseFactory { get; set; }

    internal InnerClusterCloudWatchLogsFactory CloudWatchLogsFactory { get; set; }

    protected override Humidifier.MSK.ClusterTypes.AuthorizerLogs Create()
    {
        var authorizerLogsResult = CreateAuthorizerLogs();
        factoryAction?.Invoke(authorizerLogsResult);

        return authorizerLogsResult;
    }

    private Humidifier.MSK.ClusterTypes.AuthorizerLogs CreateAuthorizerLogs()
    {
        var authorizerLogsResult = new Humidifier.MSK.ClusterTypes.AuthorizerLogs();

        return authorizerLogsResult;
    }
    public override void CreateChildren(Humidifier.MSK.ClusterTypes.AuthorizerLogs result)
    {
        base.CreateChildren(result);

        result.S3 ??= S3Factory?.Build();
        result.Firehose ??= FirehoseFactory?.Build();
        result.CloudWatchLogs ??= CloudWatchLogsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterAuthorizerLogsFactoryExtensions
{
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, InnerClusterS3Factory> WithS3(this InnerClusterAuthorizerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null)
    {
        parentFactory.S3Factory = new InnerClusterS3Factory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3Factory);
    }

    public static CombinedResult<InnerClusterAuthorizerLogsFactory, InnerClusterFirehoseFactory> WithFirehose(this InnerClusterAuthorizerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null)
    {
        parentFactory.FirehoseFactory = new InnerClusterFirehoseFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FirehoseFactory);
    }

    public static CombinedResult<InnerClusterAuthorizerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs(this InnerClusterAuthorizerLogsFactory parentFactory, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null)
    {
        parentFactory.CloudWatchLogsFactory = new InnerClusterCloudWatchLogsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchLogsFactory);
    }

    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, InnerClusterS3Factory> WithS3<T1>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, InnerClusterS3Factory> WithS3<T1>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory, InnerClusterS3Factory> WithS3<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.S3> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, InnerClusterFirehoseFactory> WithFirehose<T1>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory, InnerClusterFirehoseFactory> WithFirehose<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.Firehose> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFirehose(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<InnerClusterAuthorizerLogsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterAuthorizerLogsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterAuthorizerLogsFactory, T3, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterAuthorizerLogsFactory, T4> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory, InnerClusterCloudWatchLogsFactory> WithCloudWatchLogs<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterAuthorizerLogsFactory> combinedResult, Action<Humidifier.MSK.ClusterTypes.CloudWatchLogs> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchLogs(combinedResult.T5, subFactoryAction).T2);
}
