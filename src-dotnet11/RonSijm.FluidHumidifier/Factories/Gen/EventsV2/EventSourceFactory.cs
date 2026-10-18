// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EventsV2;

public class EventSourceFactory(string resourceName = null, Action<Humidifier.EventsV2.EventSource> factoryAction = null) : ResourceFactory<Humidifier.EventsV2.EventSource>(resourceName)
{

    internal InnerEventSourceEventSourceConfigurationFactory ConfigurationFactory { get; set; }

    protected override Humidifier.EventsV2.EventSource Create()
    {
        var eventSourceResult = CreateEventSource();
        factoryAction?.Invoke(eventSourceResult);

        return eventSourceResult;
    }

    private Humidifier.EventsV2.EventSource CreateEventSource()
    {
        var eventSourceResult = new Humidifier.EventsV2.EventSource
        {
            GivenName = InputResourceName,
        };

        return eventSourceResult;
    }
    public override void CreateChildren(Humidifier.EventsV2.EventSource result)
    {
        base.CreateChildren(result);

        result.Configuration ??= ConfigurationFactory?.Build();
    }

} // End Of Class

public static class EventSourceFactoryExtensions
{
    public static CombinedResult<EventSourceFactory, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration(this EventSourceFactory parentFactory, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null)
    {
        parentFactory.ConfigurationFactory = new InnerEventSourceEventSourceConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationFactory);
    }

    public static CombinedResult<EventSourceFactory, T1, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<EventSourceFactory, T1> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventSourceFactory, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1>(this CombinedResult<T1, EventSourceFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventSourceFactory, T1, T2, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<EventSourceFactory, T1, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventSourceFactory, T2, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, EventSourceFactory, T2> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventSourceFactory, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2>(this CombinedResult<T1, T2, EventSourceFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventSourceFactory, T1, T2, T3, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<EventSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventSourceFactory, T2, T3, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, EventSourceFactory, T2, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventSourceFactory, T3, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, EventSourceFactory, T3> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventSourceFactory, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventSourceFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventSourceFactory, T1, T2, T3, T4, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<EventSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventSourceFactory, T2, T3, T4, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, EventSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventSourceFactory, T3, T4, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventSourceFactory, T3, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventSourceFactory, T4, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventSourceFactory, T4> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventSourceFactory, InnerEventSourceEventSourceConfigurationFactory> WithConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventSourceFactory> combinedResult, Action<Humidifier.EventsV2.EventSourceTypes.EventSourceConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfiguration(combinedResult.T5, subFactoryAction).T2);
}
