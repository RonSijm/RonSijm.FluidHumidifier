// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class EventBusFactory(string resourceName = null, Action<Humidifier.Events.EventBus> factoryAction = null) : ResourceFactory<Humidifier.Events.EventBus>(resourceName)
{

    internal InnerEventBusDeadLetterConfigFactory DeadLetterConfigFactory { get; set; }

    internal InnerEventBusLogConfigFactory LogConfigFactory { get; set; }

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
        result.LogConfig ??= LogConfigFactory?.Build();
    }

} // End Of Class

public static class EventBusFactoryExtensions
{
    public static CombinedResult<EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig(this EventBusFactory parentFactory, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null)
    {
        parentFactory.DeadLetterConfigFactory = new InnerEventBusDeadLetterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DeadLetterConfigFactory);
    }

    public static CombinedResult<EventBusFactory, InnerEventBusLogConfigFactory> WithLogConfig(this EventBusFactory parentFactory, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null)
    {
        parentFactory.LogConfigFactory = new InnerEventBusLogConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigFactory);
    }

    public static CombinedResult<EventBusFactory, T1, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<EventBusFactory, T1> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1>(this CombinedResult<T1, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<EventBusFactory, T1, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, EventBusFactory, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2>(this CombinedResult<T1, T2, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<EventBusFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, EventBusFactory, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, EventBusFactory, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<EventBusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, EventBusFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusFactory, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, T4, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusFactory, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventBusFactory, InnerEventBusDeadLetterConfigFactory> WithDeadLetterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.DeadLetterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeadLetterConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, InnerEventBusLogConfigFactory> WithLogConfig<T1>(this CombinedResult<EventBusFactory, T1> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, InnerEventBusLogConfigFactory> WithLogConfig<T1>(this CombinedResult<T1, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<EventBusFactory, T1, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<T1, EventBusFactory, T2> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2>(this CombinedResult<T1, T2, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<EventBusFactory, T1, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, EventBusFactory, T2, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, T2, EventBusFactory, T3> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventBusFactory, T1, T2, T3, T4, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<EventBusFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventBusFactory, T2, T3, T4, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, EventBusFactory, T2, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventBusFactory, T3, T4, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBusFactory, T3, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventBusFactory, T4, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBusFactory, T4> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventBusFactory, InnerEventBusLogConfigFactory> WithLogConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBusFactory> combinedResult, Action<Humidifier.Events.EventBusTypes.LogConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfig(combinedResult.T5, subFactoryAction).T2);
}
