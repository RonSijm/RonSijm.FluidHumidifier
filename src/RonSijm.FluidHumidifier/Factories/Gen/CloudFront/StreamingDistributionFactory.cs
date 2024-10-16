// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class StreamingDistributionFactory(string resourceName = null, Action<Humidifier.CloudFront.StreamingDistribution> factoryAction = null) : ResourceFactory<Humidifier.CloudFront.StreamingDistribution>(resourceName)
{

    internal InnerStreamingDistributionStreamingDistributionConfigFactory StreamingDistributionConfigFactory { get; set; }

    protected override Humidifier.CloudFront.StreamingDistribution Create()
    {
        var streamingDistributionResult = CreateStreamingDistribution();
        factoryAction?.Invoke(streamingDistributionResult);

        return streamingDistributionResult;
    }

    private Humidifier.CloudFront.StreamingDistribution CreateStreamingDistribution()
    {
        var streamingDistributionResult = new Humidifier.CloudFront.StreamingDistribution
        {
            GivenName = InputResourceName,
        };

        return streamingDistributionResult;
    }
    public override void CreateChildren(Humidifier.CloudFront.StreamingDistribution result)
    {
        base.CreateChildren(result);

        result.StreamingDistributionConfig ??= StreamingDistributionConfigFactory?.Build();
    }

} // End Of Class

public static class StreamingDistributionFactoryExtensions
{
    public static CombinedResult<StreamingDistributionFactory, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig(this StreamingDistributionFactory parentFactory, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null)
    {
        parentFactory.StreamingDistributionConfigFactory = new InnerStreamingDistributionStreamingDistributionConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StreamingDistributionConfigFactory);
    }

    public static CombinedResult<StreamingDistributionFactory, T1, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1>(this CombinedResult<StreamingDistributionFactory, T1> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamingDistributionFactory, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1>(this CombinedResult<T1, StreamingDistributionFactory> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<StreamingDistributionFactory, T1, T2, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2>(this CombinedResult<StreamingDistributionFactory, T1, T2> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamingDistributionFactory, T2, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2>(this CombinedResult<T1, StreamingDistributionFactory, T2> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamingDistributionFactory, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2>(this CombinedResult<T1, T2, StreamingDistributionFactory> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<StreamingDistributionFactory, T1, T2, T3, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3>(this CombinedResult<StreamingDistributionFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamingDistributionFactory, T2, T3, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3>(this CombinedResult<T1, StreamingDistributionFactory, T2, T3> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamingDistributionFactory, T3, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3>(this CombinedResult<T1, T2, StreamingDistributionFactory, T3> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamingDistributionFactory, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, StreamingDistributionFactory> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<StreamingDistributionFactory, T1, T2, T3, T4, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3, T4>(this CombinedResult<StreamingDistributionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, StreamingDistributionFactory, T2, T3, T4, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, StreamingDistributionFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, StreamingDistributionFactory, T3, T4, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, StreamingDistributionFactory, T3, T4> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, StreamingDistributionFactory, T4, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, StreamingDistributionFactory, T4> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, StreamingDistributionFactory, InnerStreamingDistributionStreamingDistributionConfigFactory> WithStreamingDistributionConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, StreamingDistributionFactory> combinedResult, Action<Humidifier.CloudFront.StreamingDistributionTypes.StreamingDistributionConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStreamingDistributionConfig(combinedResult.T5, subFactoryAction));
}
