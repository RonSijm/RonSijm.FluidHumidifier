// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EventBusPolicyFactory(string resourceName = null, Action<Humidifier.Events.EventBusPolicy> factoryAction = null) : ResourceFactory<Humidifier.Events.EventBusPolicy>(resourceName)
{

    internal InnerEventBusPolicyConditionFactory ConditionFactory { get; set; }

    protected override Humidifier.Events.EventBusPolicy Create()
    {
        var eventBusPolicyResult = CreateEventBusPolicy();
        factoryAction?.Invoke(eventBusPolicyResult);

        return eventBusPolicyResult;
    }

    private Humidifier.Events.EventBusPolicy CreateEventBusPolicy()
    {
        var eventBusPolicyResult = new Humidifier.Events.EventBusPolicy
        {
            GivenName = InputResourceName,
        };

        return eventBusPolicyResult;
    }
    public override void CreateChildren(Humidifier.Events.EventBusPolicy result)
    {
        base.CreateChildren(result);

        result.Condition ??= ConditionFactory?.Build();
    }

} // End Of Class

public static class EventBusPolicyFactoryExtensions
{
    public static CombinedResult<EventBusPolicyFactory, InnerEventBusPolicyConditionFactory> WithCondition(this EventBusPolicyFactory parentFactory, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null)
    {
        parentFactory.ConditionFactory = new InnerEventBusPolicyConditionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConditionFactory);
    }

    public static CombinedResult<EventBusPolicyFactory, T1, InnerEventBusPolicyConditionFactory> WithCondition<T1>(this CombinedResult<EventBusPolicyFactory, T1> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusPolicyFactory, InnerEventBusPolicyConditionFactory> WithCondition<T1>(this CombinedResult<T1, EventBusPolicyFactory> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventBusPolicyFactory, T1, T2, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2>(this CombinedResult<EventBusPolicyFactory, T1, T2> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusPolicyFactory, T2, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2>(this CombinedResult<T1, EventBusPolicyFactory, T2> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusPolicyFactory, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2>(this CombinedResult<T1, T2, EventBusPolicyFactory> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventBusPolicyFactory, T1, T2, T3, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<EventBusPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusPolicyFactory, T2, T3, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, EventBusPolicyFactory, T2, T3> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusPolicyFactory, T3, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, T2, EventBusPolicyFactory, T3> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBusPolicyFactory, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusPolicyFactory> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventBusPolicyFactory, T1, T2, T3, T4, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<EventBusPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusPolicyFactory, T2, T3, T4, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, EventBusPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusPolicyFactory, T3, T4, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusPolicyFactory, T3, T4> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBusPolicyFactory, T4, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusPolicyFactory, T4> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventBusPolicyFactory, InnerEventBusPolicyConditionFactory> WithCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusPolicyFactory> combinedResult, Action<Humidifier.Events.EventBusPolicyTypes.Condition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCondition(combinedResult.T5, subFactoryAction));
}
