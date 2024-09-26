// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleBatchParametersFactory(Action<Humidifier.Events.RuleTypes.BatchParameters> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.BatchParameters>
{

    internal InnerRuleBatchArrayPropertiesFactory ArrayPropertiesFactory { get; set; }

    internal InnerRuleBatchRetryStrategyFactory RetryStrategyFactory { get; set; }

    protected override Humidifier.Events.RuleTypes.BatchParameters Create()
    {
        var batchParametersResult = CreateBatchParameters();
        factoryAction?.Invoke(batchParametersResult);

        return batchParametersResult;
    }

    private Humidifier.Events.RuleTypes.BatchParameters CreateBatchParameters()
    {
        var batchParametersResult = new Humidifier.Events.RuleTypes.BatchParameters();

        return batchParametersResult;
    }
    public override void CreateChildren(Humidifier.Events.RuleTypes.BatchParameters result)
    {
        base.CreateChildren(result);

        result.ArrayProperties ??= ArrayPropertiesFactory?.Build();
        result.RetryStrategy ??= RetryStrategyFactory?.Build();
    }

} // End Of Class

public static class InnerRuleBatchParametersFactoryExtensions
{
    public static CombinedResult<InnerRuleBatchParametersFactory, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties(this InnerRuleBatchParametersFactory parentFactory, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null)
    {
        parentFactory.ArrayPropertiesFactory = new InnerRuleBatchArrayPropertiesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ArrayPropertiesFactory);
    }

    public static CombinedResult<InnerRuleBatchParametersFactory, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy(this InnerRuleBatchParametersFactory parentFactory, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null)
    {
        parentFactory.RetryStrategyFactory = new InnerRuleBatchRetryStrategyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetryStrategyFactory);
    }

    public static CombinedResult<InnerRuleBatchParametersFactory, T1, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1>(this CombinedResult<InnerRuleBatchParametersFactory, T1> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithArrayProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1>(this CombinedResult<T1, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, WithArrayProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, T4, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3, T4>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, T4, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, T4, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, T4, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleBatchParametersFactory, InnerRuleBatchArrayPropertiesFactory> WithArrayProperties<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchArrayProperties> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithArrayProperties(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1>(this CombinedResult<InnerRuleBatchParametersFactory, T1> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1>(this CombinedResult<T1, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetryStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, T4, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3, T4>(this CombinedResult<InnerRuleBatchParametersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, T4, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleBatchParametersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, T4, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleBatchParametersFactory, T3, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, T4, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleBatchParametersFactory, T4> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleBatchParametersFactory, InnerRuleBatchRetryStrategyFactory> WithRetryStrategy<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleBatchParametersFactory> combinedResult, Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetryStrategy(combinedResult.T5, subFactoryAction));
}
