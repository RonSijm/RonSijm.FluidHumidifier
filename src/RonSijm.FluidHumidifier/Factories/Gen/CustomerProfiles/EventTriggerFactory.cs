// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class EventTriggerFactory(string resourceName = null, Action<Humidifier.CustomerProfiles.EventTrigger> factoryAction = null) : ResourceFactory<Humidifier.CustomerProfiles.EventTrigger>(resourceName)
{

    internal List<InnerEventTriggerEventTriggerConditionFactory> EventTriggerConditionsFactories { get; set; } = [];

    internal InnerEventTriggerEventTriggerLimitsFactory EventTriggerLimitsFactory { get; set; }

    protected override Humidifier.CustomerProfiles.EventTrigger Create()
    {
        var eventTriggerResult = CreateEventTrigger();
        factoryAction?.Invoke(eventTriggerResult);

        return eventTriggerResult;
    }

    private Humidifier.CustomerProfiles.EventTrigger CreateEventTrigger()
    {
        var eventTriggerResult = new Humidifier.CustomerProfiles.EventTrigger
        {
            GivenName = InputResourceName,
        };

        return eventTriggerResult;
    }
    public override void CreateChildren(Humidifier.CustomerProfiles.EventTrigger result)
    {
        base.CreateChildren(result);

        result.EventTriggerConditions = EventTriggerConditionsFactories.Any() ? EventTriggerConditionsFactories.Select(x => x.Build()).ToList() : null;
        result.EventTriggerLimits ??= EventTriggerLimitsFactory?.Build();
    }

} // End Of Class

public static class EventTriggerFactoryExtensions
{
    public static CombinedResult<EventTriggerFactory, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions(this EventTriggerFactory parentFactory, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null)
    {
        var factory = new InnerEventTriggerEventTriggerConditionFactory(subFactoryAction);
        parentFactory.EventTriggerConditionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventTriggerFactory, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits(this EventTriggerFactory parentFactory, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null)
    {
        parentFactory.EventTriggerLimitsFactory = new InnerEventTriggerEventTriggerLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventTriggerLimitsFactory);
    }

    public static CombinedResult<EventTriggerFactory, T1, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1>(this CombinedResult<EventTriggerFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1>(this CombinedResult<T1, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2>(this CombinedResult<EventTriggerFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2>(this CombinedResult<T1, EventTriggerFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2>(this CombinedResult<T1, T2, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, T3, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3>(this CombinedResult<EventTriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, T3, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3>(this CombinedResult<T1, EventTriggerFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, T3, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3>(this CombinedResult<T1, T2, EventTriggerFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventTriggerFactory, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, T3, T4, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3, T4>(this CombinedResult<EventTriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, T3, T4, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3, T4>(this CombinedResult<T1, EventTriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, T3, T4, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventTriggerFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventTriggerFactory, T4, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventTriggerFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventTriggerFactory, InnerEventTriggerEventTriggerConditionFactory> WithEventTriggerConditions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerConditions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1>(this CombinedResult<EventTriggerFactory, T1> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1>(this CombinedResult<T1, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2>(this CombinedResult<EventTriggerFactory, T1, T2> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2>(this CombinedResult<T1, EventTriggerFactory, T2> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2>(this CombinedResult<T1, T2, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, T3, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3>(this CombinedResult<EventTriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, T3, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3>(this CombinedResult<T1, EventTriggerFactory, T2, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, T3, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3>(this CombinedResult<T1, T2, EventTriggerFactory, T3> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventTriggerFactory, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventTriggerFactory, T1, T2, T3, T4, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3, T4>(this CombinedResult<EventTriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventTriggerFactory, T2, T3, T4, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3, T4>(this CombinedResult<T1, EventTriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventTriggerFactory, T3, T4, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventTriggerFactory, T3, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventTriggerFactory, T4, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventTriggerFactory, T4> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventTriggerFactory, InnerEventTriggerEventTriggerLimitsFactory> WithEventTriggerLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventTriggerFactory> combinedResult, Action<Humidifier.CustomerProfiles.EventTriggerTypes.EventTriggerLimits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTriggerLimits(combinedResult.T5, subFactoryAction).T2);
}
