// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketAnalyticsConfigurationFactory(Action<Humidifier.S3.BucketTypes.AnalyticsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.AnalyticsConfiguration>
{

    internal InnerBucketStorageClassAnalysisFactory StorageClassAnalysisFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.AnalyticsConfiguration Create()
    {
        var analyticsConfigurationResult = CreateAnalyticsConfiguration();
        factoryAction?.Invoke(analyticsConfigurationResult);

        return analyticsConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.AnalyticsConfiguration CreateAnalyticsConfiguration()
    {
        var analyticsConfigurationResult = new Humidifier.S3.BucketTypes.AnalyticsConfiguration();

        return analyticsConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.AnalyticsConfiguration result)
    {
        base.CreateChildren(result);

        result.StorageClassAnalysis ??= StorageClassAnalysisFactory?.Build();
    }

} // End Of Class

public static class InnerBucketAnalyticsConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketAnalyticsConfigurationFactory, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis(this InnerBucketAnalyticsConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null)
    {
        parentFactory.StorageClassAnalysisFactory = new InnerBucketStorageClassAnalysisFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StorageClassAnalysisFactory);
    }

    public static CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1>(this CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1>(this CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2>(this CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2>(this CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2>(this CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2, T3, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3>(this CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2, T3, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3>(this CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory, T3, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketAnalyticsConfigurationFactory, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2, T3, T4, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3, T4>(this CombinedResult<InnerBucketAnalyticsConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2, T3, T4, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketAnalyticsConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory, T3, T4, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketAnalyticsConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketAnalyticsConfigurationFactory, T4, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketAnalyticsConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketAnalyticsConfigurationFactory, InnerBucketStorageClassAnalysisFactory> WithStorageClassAnalysis<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketAnalyticsConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.StorageClassAnalysis> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStorageClassAnalysis(combinedResult.T5, subFactoryAction));
}
