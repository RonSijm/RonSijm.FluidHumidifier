// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudTrail;

public class EventDataStoreFactory(string resourceName = null, Action<Humidifier.CloudTrail.EventDataStore> factoryAction = null) : ResourceFactory<Humidifier.CloudTrail.EventDataStore>(resourceName)
{

    internal List<InnerEventDataStoreAdvancedEventSelectorFactory> AdvancedEventSelectorsFactories { get; set; } = [];

    internal List<InnerEventDataStoreInsightSelectorFactory> InsightSelectorsFactories { get; set; } = [];

    protected override Humidifier.CloudTrail.EventDataStore Create()
    {
        var eventDataStoreResult = CreateEventDataStore();
        factoryAction?.Invoke(eventDataStoreResult);

        return eventDataStoreResult;
    }

    private Humidifier.CloudTrail.EventDataStore CreateEventDataStore()
    {
        var eventDataStoreResult = new Humidifier.CloudTrail.EventDataStore
        {
            GivenName = InputResourceName,
        };

        return eventDataStoreResult;
    }
    public override void CreateChildren(Humidifier.CloudTrail.EventDataStore result)
    {
        base.CreateChildren(result);

        result.AdvancedEventSelectors = AdvancedEventSelectorsFactories.Any() ? AdvancedEventSelectorsFactories.Select(x => x.Build()).ToList() : null;
        result.InsightSelectors = InsightSelectorsFactories.Any() ? InsightSelectorsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EventDataStoreFactoryExtensions
{
    public static CombinedResult<EventDataStoreFactory, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors(this EventDataStoreFactory parentFactory, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null)
    {
        var factory = new InnerEventDataStoreAdvancedEventSelectorFactory(subFactoryAction);
        parentFactory.AdvancedEventSelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventDataStoreFactory, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors(this EventDataStoreFactory parentFactory, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null)
    {
        var factory = new InnerEventDataStoreInsightSelectorFactory(subFactoryAction);
        parentFactory.InsightSelectorsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventDataStoreFactory, T1, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1>(this CombinedResult<EventDataStoreFactory, T1> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1>(this CombinedResult<T1, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<EventDataStoreFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<T1, EventDataStoreFactory, T2> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2>(this CombinedResult<T1, T2, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, T3, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<EventDataStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, T3, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, EventDataStoreFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, T3, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, EventDataStoreFactory, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventDataStoreFactory, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, T3, T4, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<EventDataStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, T3, T4, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, EventDataStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, T3, T4, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventDataStoreFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventDataStoreFactory, T4, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventDataStoreFactory, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventDataStoreFactory, InnerEventDataStoreAdvancedEventSelectorFactory> WithAdvancedEventSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.AdvancedEventSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAdvancedEventSelectors(combinedResult.T5, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1>(this CombinedResult<EventDataStoreFactory, T1> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1>(this CombinedResult<T1, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<EventDataStoreFactory, T1, T2> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<T1, EventDataStoreFactory, T2> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2>(this CombinedResult<T1, T2, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, T3, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<EventDataStoreFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, T3, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, EventDataStoreFactory, T2, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, T3, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, T2, EventDataStoreFactory, T3> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventDataStoreFactory, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventDataStoreFactory, T1, T2, T3, T4, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<EventDataStoreFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventDataStoreFactory, T2, T3, T4, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, EventDataStoreFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventDataStoreFactory, T3, T4, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventDataStoreFactory, T3, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventDataStoreFactory, T4, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventDataStoreFactory, T4> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventDataStoreFactory, InnerEventDataStoreInsightSelectorFactory> WithInsightSelectors<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventDataStoreFactory> combinedResult, Action<Humidifier.CloudTrail.EventDataStoreTypes.InsightSelector> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInsightSelectors(combinedResult.T5, subFactoryAction));
}
