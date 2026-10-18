// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleBatchRetryStrategyFactory(Action<Humidifier.Events.RuleTypes.BatchRetryStrategy> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.BatchRetryStrategy>
{

    protected override Humidifier.Events.RuleTypes.BatchRetryStrategy Create()
    {
        var batchRetryStrategyResult = CreateBatchRetryStrategy();
        factoryAction?.Invoke(batchRetryStrategyResult);

        return batchRetryStrategyResult;
    }

    private Humidifier.Events.RuleTypes.BatchRetryStrategy CreateBatchRetryStrategy()
    {
        var batchRetryStrategyResult = new Humidifier.Events.RuleTypes.BatchRetryStrategy();

        return batchRetryStrategyResult;
    }

} // End Of Class

public static class InnerRuleBatchRetryStrategyFactoryExtensions
{
}
