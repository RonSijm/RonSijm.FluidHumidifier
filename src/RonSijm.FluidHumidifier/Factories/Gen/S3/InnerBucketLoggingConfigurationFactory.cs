// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketLoggingConfigurationFactory(Action<Humidifier.S3.BucketTypes.LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.LoggingConfiguration>
{

    internal InnerBucketTargetObjectKeyFormatFactory TargetObjectKeyFormatFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.LoggingConfiguration Create()
    {
        var loggingConfigurationResult = CreateLoggingConfiguration();
        factoryAction?.Invoke(loggingConfigurationResult);

        return loggingConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.LoggingConfiguration CreateLoggingConfiguration()
    {
        var loggingConfigurationResult = new Humidifier.S3.BucketTypes.LoggingConfiguration();

        return loggingConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.LoggingConfiguration result)
    {
        base.CreateChildren(result);

        result.TargetObjectKeyFormat ??= TargetObjectKeyFormatFactory?.Build();
    }

} // End Of Class

public static class InnerBucketLoggingConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketLoggingConfigurationFactory, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat(this InnerBucketLoggingConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null)
    {
        parentFactory.TargetObjectKeyFormatFactory = new InnerBucketTargetObjectKeyFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetObjectKeyFormatFactory);
    }

    public static CombinedResult<InnerBucketLoggingConfigurationFactory, T1, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1>(this CombinedResult<InnerBucketLoggingConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketLoggingConfigurationFactory, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1>(this CombinedResult<T1, InnerBucketLoggingConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2>(this CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2>(this CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2>(this CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2, T3, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3>(this CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2, T3, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3>(this CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory, T3, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketLoggingConfigurationFactory, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketLoggingConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2, T3, T4, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3, T4>(this CombinedResult<InnerBucketLoggingConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2, T3, T4, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketLoggingConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory, T3, T4, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketLoggingConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketLoggingConfigurationFactory, T4, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketLoggingConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketLoggingConfigurationFactory, InnerBucketTargetObjectKeyFormatFactory> WithTargetObjectKeyFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketLoggingConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.TargetObjectKeyFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetObjectKeyFormat(combinedResult.T5, subFactoryAction));
}
