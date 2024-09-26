// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFlow;

public class InnerFlowUpsolverS3OutputFormatConfigFactory(Action<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig>
{

    internal InnerFlowPrefixConfigFactory PrefixConfigFactory { get; set; }

    internal InnerFlowAggregationConfigFactory AggregationConfigFactory { get; set; }

    protected override Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig Create()
    {
        var upsolverS3OutputFormatConfigResult = CreateUpsolverS3OutputFormatConfig();
        factoryAction?.Invoke(upsolverS3OutputFormatConfigResult);

        return upsolverS3OutputFormatConfigResult;
    }

    private Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig CreateUpsolverS3OutputFormatConfig()
    {
        var upsolverS3OutputFormatConfigResult = new Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig();

        return upsolverS3OutputFormatConfigResult;
    }
    public override void CreateChildren(Humidifier.AppFlow.FlowTypes.UpsolverS3OutputFormatConfig result)
    {
        base.CreateChildren(result);

        result.PrefixConfig ??= PrefixConfigFactory?.Build();
        result.AggregationConfig ??= AggregationConfigFactory?.Build();
    }

} // End Of Class

public static class InnerFlowUpsolverS3OutputFormatConfigFactoryExtensions
{
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig(this InnerFlowUpsolverS3OutputFormatConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null)
    {
        parentFactory.PrefixConfigFactory = new InnerFlowPrefixConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PrefixConfigFactory);
    }

    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig(this InnerFlowUpsolverS3OutputFormatConfigFactory parentFactory, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null)
    {
        parentFactory.AggregationConfigFactory = new InnerFlowAggregationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AggregationConfigFactory);
    }

    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, T4, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowPrefixConfigFactory> WithPrefixConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.PrefixConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPrefixConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<InnerFlowUpsolverS3OutputFormatConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowUpsolverS3OutputFormatConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowUpsolverS3OutputFormatConfigFactory, T3, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, T4, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowUpsolverS3OutputFormatConfigFactory, T4> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory, InnerFlowAggregationConfigFactory> WithAggregationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowUpsolverS3OutputFormatConfigFactory> combinedResult, Action<Humidifier.AppFlow.FlowTypes.AggregationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAggregationConfig(combinedResult.T5, subFactoryAction));
}
