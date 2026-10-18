// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class TriggerFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.Trigger> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.Trigger>(resourceName)
{

    internal InnerTriggerConditionFactory ConditionFactory { get; set; }

    protected override Humidifier.DevOpsAgent.Trigger Create()
    {
        var triggerResult = CreateTrigger();
        factoryAction?.Invoke(triggerResult);

        return triggerResult;
    }

    private Humidifier.DevOpsAgent.Trigger CreateTrigger()
    {
        var triggerResult = new Humidifier.DevOpsAgent.Trigger
        {
            GivenName = InputResourceName,
        };

        return triggerResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.Trigger result)
    {
        base.CreateChildren(result);

        result.Condition ??= ConditionFactory?.Build();
    }

} // End Of Class

public static class TriggerFactoryExtensions
{
    public static CombinedResult<TriggerFactory, InnerTriggerConditionFactory> WithCondition(this TriggerFactory parentFactory, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null)
    {
        parentFactory.ConditionFactory = new InnerTriggerConditionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionFactory);
    }

    public static CombinedResult<TriggerFactory, T1, InnerTriggerConditionFactory> WithCondition<T1>(this CombinedResult<TriggerFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TriggerFactory, InnerTriggerConditionFactory> WithCondition<T1>(this CombinedResult<T1, TriggerFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<TriggerFactory, T1, T2, InnerTriggerConditionFactory> WithCondition<T1, T2>(this CombinedResult<TriggerFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TriggerFactory, T2, InnerTriggerConditionFactory> WithCondition<T1, T2>(this CombinedResult<T1, TriggerFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TriggerFactory, InnerTriggerConditionFactory> WithCondition<T1, T2>(this CombinedResult<T1, T2, TriggerFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<TriggerFactory, T1, T2, T3, InnerTriggerConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<TriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TriggerFactory, T2, T3, InnerTriggerConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, TriggerFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TriggerFactory, T3, InnerTriggerConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, T2, TriggerFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TriggerFactory, InnerTriggerConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, T2, T3, TriggerFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<TriggerFactory, T1, T2, T3, T4, InnerTriggerConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<TriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, TriggerFactory, T2, T3, T4, InnerTriggerConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, TriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, TriggerFactory, T3, T4, InnerTriggerConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, TriggerFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, TriggerFactory, T4, InnerTriggerConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TriggerFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, TriggerFactory, InnerTriggerConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TriggerFactory> combinedResult, Action<Humidifier.DevOpsAgent.TriggerTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T5, subFactoryAction).T2);
}
