// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class EventBridgeRuleTemplateFactory(string resourceName = null, Action<Humidifier.MediaLive.EventBridgeRuleTemplate> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.EventBridgeRuleTemplate>(resourceName)
{

    internal List<InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> EventTargetsFactories { get; set; } = [];

    protected override Humidifier.MediaLive.EventBridgeRuleTemplate Create()
    {
        var eventBridgeRuleTemplateResult = CreateEventBridgeRuleTemplate();
        factoryAction?.Invoke(eventBridgeRuleTemplateResult);

        return eventBridgeRuleTemplateResult;
    }

    private Humidifier.MediaLive.EventBridgeRuleTemplate CreateEventBridgeRuleTemplate()
    {
        var eventBridgeRuleTemplateResult = new Humidifier.MediaLive.EventBridgeRuleTemplate
        {
            GivenName = InputResourceName,
        };

        return eventBridgeRuleTemplateResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.EventBridgeRuleTemplate result)
    {
        base.CreateChildren(result);

        result.EventTargets = EventTargetsFactories.Any() ? EventTargetsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class EventBridgeRuleTemplateFactoryExtensions
{
    public static CombinedResult<EventBridgeRuleTemplateFactory, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets(this EventBridgeRuleTemplateFactory parentFactory, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null)
    {
        var factory = new InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory(subFactoryAction);
        parentFactory.EventTargetsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<EventBridgeRuleTemplateFactory, T1, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1>(this CombinedResult<EventBridgeRuleTemplateFactory, T1> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBridgeRuleTemplateFactory, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1>(this CombinedResult<T1, EventBridgeRuleTemplateFactory> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<EventBridgeRuleTemplateFactory, T1, T2, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2>(this CombinedResult<EventBridgeRuleTemplateFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBridgeRuleTemplateFactory, T2, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2>(this CombinedResult<T1, EventBridgeRuleTemplateFactory, T2> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBridgeRuleTemplateFactory, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2>(this CombinedResult<T1, T2, EventBridgeRuleTemplateFactory> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<EventBridgeRuleTemplateFactory, T1, T2, T3, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3>(this CombinedResult<EventBridgeRuleTemplateFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBridgeRuleTemplateFactory, T2, T3, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3>(this CombinedResult<T1, EventBridgeRuleTemplateFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBridgeRuleTemplateFactory, T3, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3>(this CombinedResult<T1, T2, EventBridgeRuleTemplateFactory, T3> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBridgeRuleTemplateFactory, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventBridgeRuleTemplateFactory> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<EventBridgeRuleTemplateFactory, T1, T2, T3, T4, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3, T4>(this CombinedResult<EventBridgeRuleTemplateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, EventBridgeRuleTemplateFactory, T2, T3, T4, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3, T4>(this CombinedResult<T1, EventBridgeRuleTemplateFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, EventBridgeRuleTemplateFactory, T3, T4, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventBridgeRuleTemplateFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, EventBridgeRuleTemplateFactory, T4, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventBridgeRuleTemplateFactory, T4> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, EventBridgeRuleTemplateFactory, InnerEventBridgeRuleTemplateEventBridgeRuleTemplateTargetFactory> WithEventTargets<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventBridgeRuleTemplateFactory> combinedResult, Action<Humidifier.MediaLive.EventBridgeRuleTemplateTypes.EventBridgeRuleTemplateTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventTargets(combinedResult.T5, subFactoryAction));
}
