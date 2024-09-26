// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowS3OutputFormatConfigFactory(Action<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig>
{

    internal InnerFlowPrefixConfigFactory PrefixConfigFactory { get; set; }

    internal InnerFlowAggregationConfigFactory AggregationConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig Create()
    {
        var s3OutputFormatConfigResult = CreateS3OutputFormatConfig();
        factoryAction?.Invoke(s3OutputFormatConfigResult);

        return s3OutputFormatConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig CreateS3OutputFormatConfig()
    {
        var s3OutputFormatConfigResult = new Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig();

        return s3OutputFormatConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.S3OutputFormatConfig result)
    {
        base.CreateChildren(result);

        result.PrefixConfig ??= PrefixConfigFactory?.Build();
        result.AggregationConfig ??= AggregationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowS3OutputFormatConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig(this InnerFlowS3OutputFormatConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null)
    {
        parentFactory.PrefixConfigFactory = new InnerFlowPrefixConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrefixConfigFactory);
    }

    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig(this InnerFlowS3OutputFormatConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null)
    {
        parentFactory.AggregationConfigFactory = new InnerFlowAggregationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AggregationConfigFactory);
    }

    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowS3OutputFormatConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowS3OutputFormatConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowS3OutputFormatConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowS3OutputFormatConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T5, subFactoryAction));
}
