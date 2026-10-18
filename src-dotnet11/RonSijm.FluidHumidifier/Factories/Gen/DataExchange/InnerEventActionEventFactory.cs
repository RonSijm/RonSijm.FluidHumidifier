// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataExchange;

public class InnerEventActionEventFactory(Action<Humidifier.DataExchange.EventActionTypes.Event> factoryAction = null) : SubResourceFactory<Humidifier.DataExchange.EventActionTypes.Event>
{

    internal InnerEventActionRevisionPublishedFactory RevisionPublishedFactory { get; set; }

    protected override Humidifier.DataExchange.EventActionTypes.Event Create()
    {
        var eventResult = CreateEvent();
        factoryAction?.Invoke(eventResult);

        return eventResult;
    }

    private Humidifier.DataExchange.EventActionTypes.Event CreateEvent()
    {
        var eventResult = new Humidifier.DataExchange.EventActionTypes.Event();

        return eventResult;
    }
    public override void CreateChildren(Humidifier.DataExchange.EventActionTypes.Event result)
    {
        base.CreateChildren(result);

        result.RevisionPublished ??= RevisionPublishedFactory?.Build();
    }

} // End Of Class

public static class InnerEventActionEventFactoryExtensions
{
    public static CombinedResult<InnerEventActionEventFactory, InnerEventActionRevisionPublishedFactory> WithRevisionPublished(this InnerEventActionEventFactory parentFactory, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null)
    {
        parentFactory.RevisionPublishedFactory = new InnerEventActionRevisionPublishedFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RevisionPublishedFactory);
    }

    public static CombinedResult<InnerEventActionEventFactory, T1, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1>(this CombinedResult<InnerEventActionEventFactory, T1> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevisionPublished(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionEventFactory, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1>(this CombinedResult<T1, InnerEventActionEventFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, WithRevisionPublished(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionEventFactory, T1, T2, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2>(this CombinedResult<InnerEventActionEventFactory, T1, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionEventFactory, T2, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2>(this CombinedResult<T1, InnerEventActionEventFactory, T2> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionEventFactory, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2>(this CombinedResult<T1, T2, InnerEventActionEventFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionEventFactory, T1, T2, T3, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3>(this CombinedResult<InnerEventActionEventFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionEventFactory, T2, T3, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3>(this CombinedResult<T1, InnerEventActionEventFactory, T2, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionEventFactory, T3, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3>(this CombinedResult<T1, T2, InnerEventActionEventFactory, T3> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventActionEventFactory, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerEventActionEventFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerEventActionEventFactory, T1, T2, T3, T4, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3, T4>(this CombinedResult<InnerEventActionEventFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerEventActionEventFactory, T2, T3, T4, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3, T4>(this CombinedResult<T1, InnerEventActionEventFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerEventActionEventFactory, T3, T4, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerEventActionEventFactory, T3, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerEventActionEventFactory, T4, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerEventActionEventFactory, T4> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerEventActionEventFactory, InnerEventActionRevisionPublishedFactory> WithRevisionPublished<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerEventActionEventFactory> combinedResult, Action<Humidifier.DataExchange.EventActionTypes.RevisionPublished> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRevisionPublished(combinedResult.T5, subFactoryAction).T2);
}
