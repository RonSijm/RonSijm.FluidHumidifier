// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketDataExportFactory(Action<Humidifier.S3.BucketTypes.DataExport> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.DataExport>
{

    internal InnerBucketDestinationFactory DestinationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.DataExport Create()
    {
        var dataExportResult = CreateDataExport();
        factoryAction?.Invoke(dataExportResult);

        return dataExportResult;
    }

    private Humidifier.S3.BucketTypes.DataExport CreateDataExport()
    {
        var dataExportResult = new Humidifier.S3.BucketTypes.DataExport();

        return dataExportResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.DataExport result)
    {
        base.CreateChildren(result);

        result.Destination ??= DestinationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketDataExportFactoryExtensions
{
    public static CombinedResult<InnerBucketDataExportFactory, InnerBucketDestinationFactory> WithDestination(this InnerBucketDataExportFactory parentFactory, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null)
    {
        parentFactory.DestinationFactory = new InnerBucketDestinationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationFactory);
    }

    public static CombinedResult<InnerBucketDataExportFactory, T1, InnerBucketDestinationFactory> WithDestination<T1>(this CombinedResult<InnerBucketDataExportFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketDataExportFactory, InnerBucketDestinationFactory> WithDestination<T1>(this CombinedResult<T1, InnerBucketDataExportFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketDataExportFactory, T1, T2, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<InnerBucketDataExportFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketDataExportFactory, T2, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, InnerBucketDataExportFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketDataExportFactory, InnerBucketDestinationFactory> WithDestination<T1, T2>(this CombinedResult<T1, T2, InnerBucketDataExportFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketDataExportFactory, T1, T2, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<InnerBucketDataExportFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketDataExportFactory, T2, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, InnerBucketDataExportFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketDataExportFactory, T3, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketDataExportFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketDataExportFactory, InnerBucketDestinationFactory> WithDestination<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketDataExportFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketDataExportFactory, T1, T2, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<InnerBucketDataExportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketDataExportFactory, T2, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketDataExportFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketDataExportFactory, T3, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketDataExportFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketDataExportFactory, T4, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketDataExportFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketDataExportFactory, InnerBucketDestinationFactory> WithDestination<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketDataExportFactory> combinedResult, Action<Humidifier.S3.BucketTypes.Destination> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestination(combinedResult.T5, subFactoryAction));
}
