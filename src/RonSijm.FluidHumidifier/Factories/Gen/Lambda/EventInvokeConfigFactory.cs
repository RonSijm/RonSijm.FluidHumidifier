// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lambda;

public class EventInvokeConfigFactory(string resourceName = null, Action<Humidifier.Lambda.EventInvokeConfig> factoryAction = null) : ResourceFactory<Humidifier.Lambda.EventInvokeConfig>(resourceName)
{

    internal InnerEventInvokeConfigDestinationConfigFactory DestinationConfigFactory { get; set; }

    protected override Humidifier.Lambda.EventInvokeConfig Create()
    {
        var eventInvokeConfigResult = CreateEventInvokeConfig();
        factoryAction?.Invoke(eventInvokeConfigResult);

        return eventInvokeConfigResult;
    }

    private Humidifier.Lambda.EventInvokeConfig CreateEventInvokeConfig()
    {
        var eventInvokeConfigResult = new Humidifier.Lambda.EventInvokeConfig
        {
            GivenName = InputResourceName,
        };

        return eventInvokeConfigResult;
    }
    public override void CreateChildren(Humidifier.Lambda.EventInvokeConfig result)
    {
        base.CreateChildren(result);

        result.DestinationConfig ??= DestinationConfigFactory?.Build();
    }

} // End Of Class

public static class EventInvokeConfigFactoryExtensions
{
    public static CombinedResult<EventInvokeConfigFactory, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig(this EventInvokeConfigFactory parentFactory, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null)
    {
        parentFactory.DestinationConfigFactory = new InnerEventInvokeConfigDestinationConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DestinationConfigFactory);
    }

    public static CombinedResult<EventInvokeConfigFactory, T1, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1>(this CombinedResult<EventInvokeConfigFactory, T1> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventInvokeConfigFactory, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1>(this CombinedResult<T1, EventInvokeConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventInvokeConfigFactory, T1, T2, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<EventInvokeConfigFactory, T1, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventInvokeConfigFactory, T2, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<T1, EventInvokeConfigFactory, T2> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventInvokeConfigFactory, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2>(this CombinedResult<T1, T2, EventInvokeConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventInvokeConfigFactory, T1, T2, T3, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<EventInvokeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventInvokeConfigFactory, T2, T3, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, EventInvokeConfigFactory, T2, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventInvokeConfigFactory, T3, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, T2, EventInvokeConfigFactory, T3> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventInvokeConfigFactory, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventInvokeConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventInvokeConfigFactory, T1, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<EventInvokeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventInvokeConfigFactory, T2, T3, T4, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, EventInvokeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventInvokeConfigFactory, T3, T4, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventInvokeConfigFactory, T3, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventInvokeConfigFactory, T4, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventInvokeConfigFactory, T4> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventInvokeConfigFactory, InnerEventInvokeConfigDestinationConfigFactory> WithDestinationConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventInvokeConfigFactory> combinedResult, Action<Humidifier.Lambda.EventInvokeConfigTypes.DestinationConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDestinationConfig(combinedResult.T5, subFactoryAction));
}
