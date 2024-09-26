// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketStorageClassAnalysisFactory(Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.StorageClassAnalysis>
{

    internal InnerBucketDataExportFactory DataExportFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.StorageClassAnalysis Create()
    {
        var storageClassAnalysisResult = CreateStorageClassAnalysis();
        factoryAction?.Invoke(storageClassAnalysisResult);

        return storageClassAnalysisResult;
    }

    private Humidifier.S3.BucketTypes.StorageClassAnalysis CreateStorageClassAnalysis()
    {
        var storageClassAnalysisResult = new Humidifier.S3.BucketTypes.StorageClassAnalysis();

        return storageClassAnalysisResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.StorageClassAnalysis result)
    {
        base.CreateChildren(result);

        result.DataExport ??= DataExportFactory?.Build();
    }

} // End Of Class

public static class InnerBucketStorageClassAnalysisFactoryExtensions
{
    public static CombinedResult<InnerBucketStorageClassAnalysisFactory, InnerBucketDataExportFactory> WithDataExport(this InnerBucketStorageClassAnalysisFactory parentFactory, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null)
    {
        parentFactory.DataExportFactory = new InnerBucketDataExportFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DataExportFactory);
    }

    public static CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, InnerBucketDataExportFactory> WithDataExport<T1>(this CombinedResult<InnerBucketStorageClassAnalysisFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataExport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, InnerBucketDataExportFactory> WithDataExport<T1>(this CombinedResult<T1, InnerBucketStorageClassAnalysisFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, WithDataExport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2, InnerBucketDataExportFactory> WithDataExport<T1, T2>(this CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2, InnerBucketDataExportFactory> WithDataExport<T1, T2>(this CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory, InnerBucketDataExportFactory> WithDataExport<T1, T2>(this CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2, T3, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3>(this CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2, T3, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3>(this CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory, T3, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketStorageClassAnalysisFactory, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketStorageClassAnalysisFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2, T3, T4, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3, T4>(this CombinedResult<InnerBucketStorageClassAnalysisFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2, T3, T4, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketStorageClassAnalysisFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory, T3, T4, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketStorageClassAnalysisFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketStorageClassAnalysisFactory, T4, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketStorageClassAnalysisFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketStorageClassAnalysisFactory, InnerBucketDataExportFactory> WithDataExport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketStorageClassAnalysisFactory> combinedResult, Action<Humidifier.S3.BucketTypes.DataExport> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDataExport(combinedResult.T5, subFactoryAction));
}
