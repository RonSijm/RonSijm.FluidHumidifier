// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LookoutMetrics;

public class InnerAnomalyDetectorS3SourceConfigFactory(Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig> factoryAction = null) : SubResourceFactory<Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig>
{

    internal InnerAnomalyDetectorFileFormatDescriptorFactory FileFormatDescriptorFactory { get; set; }

    protected override Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig Create()
    {
        var s3SourceConfigResult = CreateS3SourceConfig();
        factoryAction?.Invoke(s3SourceConfigResult);

        return s3SourceConfigResult;
    }

    private Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig CreateS3SourceConfig()
    {
        var s3SourceConfigResult = new Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig();

        return s3SourceConfigResult;
    }
    public override void CreateChildren(Humidifier.LookoutMetrics.AnomalyDetectorTypes.S3SourceConfig result)
    {
        base.CreateChildren(result);

        result.FileFormatDescriptor ??= FileFormatDescriptorFactory?.Build();
    }

} // End Of Class

public static class InnerAnomalyDetectorS3SourceConfigFactoryExtensions
{
    public static CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor(this InnerAnomalyDetectorS3SourceConfigFactory parentFactory, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null)
    {
        parentFactory.FileFormatDescriptorFactory = new InnerAnomalyDetectorFileFormatDescriptorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFormatDescriptorFactory);
    }

    public static CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1>(this CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1>(this CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2>(this CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2>(this CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2>(this CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2, T3, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3>(this CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2, T3, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3>(this CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory, T3, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory, T3> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorS3SourceConfigFactory, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorS3SourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2, T3, T4, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3, T4>(this CombinedResult<InnerAnomalyDetectorS3SourceConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2, T3, T4, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, InnerAnomalyDetectorS3SourceConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory, T3, T4, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAnomalyDetectorS3SourceConfigFactory, T3, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAnomalyDetectorS3SourceConfigFactory, T4, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAnomalyDetectorS3SourceConfigFactory, T4> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorS3SourceConfigFactory, InnerAnomalyDetectorFileFormatDescriptorFactory> WithFileFormatDescriptor<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAnomalyDetectorS3SourceConfigFactory> combinedResult, Action<Humidifier.LookoutMetrics.AnomalyDetectorTypes.FileFormatDescriptor> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFileFormatDescriptor(combinedResult.T5, subFactoryAction));
}
