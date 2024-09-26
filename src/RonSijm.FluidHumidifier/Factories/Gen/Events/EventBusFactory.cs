// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EventBusFactory(string resourceName = null, Action<Humidifier.Events.EventBus> factoryAction = null) : ResourceFactory<Humidifier.Events.EventBus>(resourceName)
{

    internal InnerEventBusDeadLetterConfigFactory DeadLetterConfigFactory { get; set; }

    protected override Humidifier.Events.EventBus Create()
    {
        var eventBusResult = CreateEventBus();
        factoryAction?.Invoke(eventBusResult);

        return eventBusResult;
    }

    private Humidifier.Events.EventBus CreateEventBus()
    {
        var eventBusResult = new Humidifier.Events.EventBus
        {
            GivenName = InputResourceName,
        };

        return eventBusResult;
    }
    public override void CreateChildren(Humidifier.Events.EventBus result)
    {
        base.CreateChildren(result);

        result.DeadLetterConfig ??= DeadLetterConfigFactory?.Build();
    }

} // End Of Class

public static class EventBusFactoryExtensions
{
    public static CombinedResult<EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig(this EventBusFactory parentFactory, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null)
    {
        parentFactory.DeadLetterConfigFactory = new InnerEventBusDeadLetterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterConfigFactory);
    }

    public static CombinedResult<EventBusFactory, T1, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<EventBusFactory, T1> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<T1, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventBusFactory, T1, T2, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<EventBusFactory, T1, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusFactory, T2, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, EventBusFactory, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, T2, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventBusFactory, T1, T2, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<EventBusFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusFactory, T2, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, EventBusFactory, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusFactory, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, EventBusFactory, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventBusFactory, T1, T2, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<EventBusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBusFactory, T2, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, EventBusFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBusFactory, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusFactory, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBusFactory, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusFactory, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T5, subFactoryAction));
}
