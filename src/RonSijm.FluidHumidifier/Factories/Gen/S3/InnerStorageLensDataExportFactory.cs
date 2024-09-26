// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerStorageLensDataExportFactory(Action<Humidifier.S3.StorageLensTypes.DataExport> factoryAction = null) : SubResourceFactory<Humidifier.S3.StorageLensTypes.DataExport>
{

    internal InnerStorageLensS3BucketDestinationFactory S3BucketDestinationFactory { get; set; }

    internal InnerStorageLensCloudWatchMetricsFactory CloudWatchMetricsFactory { get; set; }

    protected override Humidifier.S3.StorageLensTypes.DataExport Create()
    {
        var dataExportResult = CreateDataExport();
        factoryAction?.Invoke(dataExportResult);

        return dataExportResult;
    }

    private Humidifier.S3.StorageLensTypes.DataExport CreateDataExport()
    {
        var dataExportResult = new Humidifier.S3.StorageLensTypes.DataExport();

        return dataExportResult;
    }
    public override void CreateChildren(Humidifier.S3.StorageLensTypes.DataExport result)
    {
        base.CreateChildren(result);

        result.S3BucketDestination ??= S3BucketDestinationFactory?.Build();
        result.CloudWatchMetrics ??= CloudWatchMetricsFactory?.Build();
    }

} // End Of Class

public static class InnerStorageLensDataExportFactoryExtensions
{
    public static CombinedResult<InnerStorageLensDataExportFactory, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination(this InnerStorageLensDataExportFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null)
    {
        parentFactory.S3BucketDestinationFactory = new InnerStorageLensS3BucketDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3BucketDestinationFactory);
    }

    public static CombinedResult<InnerStorageLensDataExportFactory, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics(this InnerStorageLensDataExportFactory parentFactory, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null)
    {
        parentFactory.CloudWatchMetricsFactory = new InnerStorageLensCloudWatchMetricsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CloudWatchMetricsFactory);
    }

    public static CombinedResult<InnerStorageLensDataExportFactory, T1, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1>(this CombinedResult<InnerStorageLensDataExportFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1>(this CombinedResult<T1, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, T4, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, T4, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, T4, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, T4, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensDataExportFactory, InnerStorageLensS3BucketDestinationFactory> WithS3BucketDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.S3BucketDestination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketDestination(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1>(this CombinedResult<InnerStorageLensDataExportFactory, T1> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1>(this CombinedResult<T1, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, T4, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3, T4>(this CombinedResult<InnerStorageLensDataExportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, T4, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3, T4>(this CombinedResult<T1, InnerStorageLensDataExportFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, T4, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerStorageLensDataExportFactory, T3, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, T4, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerStorageLensDataExportFactory, T4> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerStorageLensDataExportFactory, InnerStorageLensCloudWatchMetricsFactory> WithCloudWatchMetrics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerStorageLensDataExportFactory> combinedResult, Action<Humidifier.S3.StorageLensTypes.CloudWatchMetrics> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCloudWatchMetrics(combinedResult.T5, subFactoryAction));
}
