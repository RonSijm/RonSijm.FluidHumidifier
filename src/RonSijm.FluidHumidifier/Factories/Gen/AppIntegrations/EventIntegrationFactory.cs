// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppIntegrations;

public class EventIntegrationFactory(string resourceName = null, Action<Humidifier.AppIntegrations.EventIntegration> factoryAction = null) : ResourceFactory<Humidifier.AppIntegrations.EventIntegration>(resourceName)
{

    internal InnerEventIntegrationEventFilterFactory EventFilterFactory { get; set; }

    protected override Humidifier.AppIntegrations.EventIntegration Create()
    {
        var eventIntegrationResult = CreateEventIntegration();
        factoryAction?.Invoke(eventIntegrationResult);

        return eventIntegrationResult;
    }

    private Humidifier.AppIntegrations.EventIntegration CreateEventIntegration()
    {
        var eventIntegrationResult = new Humidifier.AppIntegrations.EventIntegration
        {
            GivenName = InputResourceName,
        };

        return eventIntegrationResult;
    }
    public override void CreateChildren(Humidifier.AppIntegrations.EventIntegration result)
    {
        base.CreateChildren(result);

        result.EventFilter ??= EventFilterFactory?.Build();
    }

} // End Of Class

public static class EventIntegrationFactoryExtensions
{
    public static CombinedResult<EventIntegrationFactory, InnerEventIntegrationEventFilterFactory> WithEventFilter(this EventIntegrationFactory parentFactory, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null)
    {
        parentFactory.EventFilterFactory = new InnerEventIntegrationEventFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventFilterFactory);
    }

    public static CombinedResult<EventIntegrationFactory, T1, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1>(this CombinedResult<EventIntegrationFactory, T1> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventIntegrationFactory, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1>(this CombinedResult<T1, EventIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventIntegrationFactory, T1, T2, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<EventIntegrationFactory, T1, T2> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventIntegrationFactory, T2, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, EventIntegrationFactory, T2> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventIntegrationFactory, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, T2, EventIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventIntegrationFactory, T1, T2, T3, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<EventIntegrationFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventIntegrationFactory, T2, T3, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, EventIntegrationFactory, T2, T3> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventIntegrationFactory, T3, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, EventIntegrationFactory, T3> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventIntegrationFactory, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventIntegrationFactory, T1, T2, T3, T4, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<EventIntegrationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventIntegrationFactory, T2, T3, T4, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, EventIntegrationFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventIntegrationFactory, T3, T4, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventIntegrationFactory, T3, T4> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventIntegrationFactory, T4, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventIntegrationFactory, T4> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventIntegrationFactory, InnerEventIntegrationEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventIntegrationFactory> combinedResult, Action<Humidifier.AppIntegrations.EventIntegrationTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T5, subFactoryAction));
}
