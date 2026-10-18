// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class EventActionFactory(string resourceName = null, Action<Humidifier.DataExchange.EventAction> factoryAction = null) : ResourceFactory<Humidifier.DataExchange.EventAction>(resourceName)
{

    internal InnerEventActionActionFactory ActionFactory { get; set; }

    internal InnerEventActionEventFactory EventFactory { get; set; }

    protected override Humidifier.DataExchange.EventAction Create()
    {
        var eventActionResult = CreateEventAction();
        factoryAction?.Invoke(eventActionResult);

        return eventActionResult;
    }

    private Humidifier.DataExchange.EventAction CreateEventAction()
    {
        var eventActionResult = new Humidifier.DataExchange.EventAction
        {
            GivenName = InputResourceName,
        };

        return eventActionResult;
    }
    public override void CreateChildren(Humidifier.DataExchange.EventAction result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Event ??= EventFactory?.Build();
    }

} // End Of Class

public static class EventActionFactoryExtensions
{
    public static CombinedResult<EventActionFactory, InnerEventActionActionFactory> WithAction(this EventActionFactory parentFactory, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerEventActionActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<EventActionFactory, InnerEventActionEventFactory> WithEvent(this EventActionFactory parentFactory, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null)
    {
        parentFactory.EventFactory = new InnerEventActionEventFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventFactory);
    }

    public static CombinedResult<EventActionFactory, T1, InnerEventActionActionFactory> WithAction<T1>(this CombinedResult<EventActionFactory, T1> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, InnerEventActionActionFactory> WithAction<T1>(this CombinedResult<T1, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, InnerEventActionActionFactory> WithAction<T1, T2>(this CombinedResult<EventActionFactory, T1, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, InnerEventActionActionFactory> WithAction<T1, T2>(this CombinedResult<T1, EventActionFactory, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, InnerEventActionActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, T3, InnerEventActionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<EventActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, T3, InnerEventActionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, EventActionFactory, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, T3, InnerEventActionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, EventActionFactory, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventActionFactory, InnerEventActionActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, T3, T4, InnerEventActionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<EventActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, T3, T4, InnerEventActionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, EventActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, T3, T4, InnerEventActionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventActionFactory, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventActionFactory, T4, InnerEventActionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventActionFactory, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventActionFactory, InnerEventActionActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, InnerEventActionEventFactory> WithEvent<T1>(this CombinedResult<EventActionFactory, T1> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, InnerEventActionEventFactory> WithEvent<T1>(this CombinedResult<T1, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, WithEvent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, InnerEventActionEventFactory> WithEvent<T1, T2>(this CombinedResult<EventActionFactory, T1, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, InnerEventActionEventFactory> WithEvent<T1, T2>(this CombinedResult<T1, EventActionFactory, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, InnerEventActionEventFactory> WithEvent<T1, T2>(this CombinedResult<T1, T2, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, T3, InnerEventActionEventFactory> WithEvent<T1, T2, T3>(this CombinedResult<EventActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, T3, InnerEventActionEventFactory> WithEvent<T1, T2, T3>(this CombinedResult<T1, EventActionFactory, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, T3, InnerEventActionEventFactory> WithEvent<T1, T2, T3>(this CombinedResult<T1, T2, EventActionFactory, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventActionFactory, InnerEventActionEventFactory> WithEvent<T1, T2, T3>(this CombinedResult<T1, T2, T3, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<EventActionFactory, T1, T2, T3, T4, InnerEventActionEventFactory> WithEvent<T1, T2, T3, T4>(this CombinedResult<EventActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, EventActionFactory, T2, T3, T4, InnerEventActionEventFactory> WithEvent<T1, T2, T3, T4>(this CombinedResult<T1, EventActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, EventActionFactory, T3, T4, InnerEventActionEventFactory> WithEvent<T1, T2, T3, T4>(this CombinedResult<T1, T2, EventActionFactory, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, EventActionFactory, T4, InnerEventActionEventFactory> WithEvent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, EventActionFactory, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, EventActionFactory, InnerEventActionEventFactory> WithEvent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, EventActionFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.Event> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEvent(combinedResult.T5, subFactoryAction).T2);
}
