// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class TriggerFactory(string resourceName = null, Action<Humidifier.Glue.Trigger> factoryAction = null) : ResourceFactory<Humidifier.Glue.Trigger>(resourceName)
{

    internal List<InnerTriggerActionFactory> ActionsFactories { get; set; } = [];

    internal InnerTriggerEventBatchingConditionFactory EventBatchingConditionFactory { get; set; }

    internal InnerTriggerPredicateFactory PredicateFactory { get; set; }

    protected override Humidifier.Glue.Trigger Create()
    {
        var triggerResult = CreateTrigger();
        factoryAction?.Invoke(triggerResult);

        return triggerResult;
    }

    private Humidifier.Glue.Trigger CreateTrigger()
    {
        var triggerResult = new Humidifier.Glue.Trigger
        {
            GivenName = InputResourceName,
        };

        return triggerResult;
    }
    public override void CreateChildren(Humidifier.Glue.Trigger result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.EventBatchingCondition ??= EventBatchingConditionFactory?.Build();
        result.Predicate ??= PredicateFactory?.Build();
    }

} // End Of Class

public static class TriggerFactoryExtensions
{
    public static CombinedResult<TriggerFactory, InnerTriggerActionFactory> WithActions(this TriggerFactory parentFactory, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null)
    {
        var factory = new InnerTriggerActionFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TriggerFactory, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition(this TriggerFactory parentFactory, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null)
    {
        parentFactory.EventBatchingConditionFactory = new InnerTriggerEventBatchingConditionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventBatchingConditionFactory);
    }

    public static CombinedResult<TriggerFactory, InnerTriggerPredicateFactory> WithPredicate(this TriggerFactory parentFactory, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null)
    {
        parentFactory.PredicateFactory = new InnerTriggerPredicateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PredicateFactory);
    }

    public static CombinedResult<TriggerFactory, T1, InnerTriggerActionFactory> WithActions<T1>(this CombinedResult<TriggerFactory, T1> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, InnerTriggerActionFactory> WithActions<T1>(this CombinedResult<T1, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, InnerTriggerActionFactory> WithActions<T1, T2>(this CombinedResult<TriggerFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, InnerTriggerActionFactory> WithActions<T1, T2>(this CombinedResult<T1, TriggerFactory, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, InnerTriggerActionFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, InnerTriggerActionFactory> WithActions<T1, T2, T3>(this CombinedResult<TriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, InnerTriggerActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, TriggerFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, InnerTriggerActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, TriggerFactory, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, InnerTriggerActionFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, T4, InnerTriggerActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<TriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, T4, InnerTriggerActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, TriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, T4, InnerTriggerActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, TriggerFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, T4, InnerTriggerActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TriggerFactory, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TriggerFactory, InnerTriggerActionFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Action> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1>(this CombinedResult<TriggerFactory, T1> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1>(this CombinedResult<T1, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2>(this CombinedResult<TriggerFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2>(this CombinedResult<T1, TriggerFactory, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2>(this CombinedResult<T1, T2, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3>(this CombinedResult<TriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3>(this CombinedResult<T1, TriggerFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3>(this CombinedResult<T1, T2, TriggerFactory, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3>(this CombinedResult<T1, T2, T3, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, T4, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3, T4>(this CombinedResult<TriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, T4, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3, T4>(this CombinedResult<T1, TriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, T4, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, TriggerFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, T4, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TriggerFactory, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TriggerFactory, InnerTriggerEventBatchingConditionFactory> WithEventBatchingCondition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.EventBatchingCondition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBatchingCondition(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, InnerTriggerPredicateFactory> WithPredicate<T1>(this CombinedResult<TriggerFactory, T1> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredicate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, InnerTriggerPredicateFactory> WithPredicate<T1>(this CombinedResult<T1, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, WithPredicate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, InnerTriggerPredicateFactory> WithPredicate<T1, T2>(this CombinedResult<TriggerFactory, T1, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, InnerTriggerPredicateFactory> WithPredicate<T1, T2>(this CombinedResult<T1, TriggerFactory, T2> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, InnerTriggerPredicateFactory> WithPredicate<T1, T2>(this CombinedResult<T1, T2, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3>(this CombinedResult<TriggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3>(this CombinedResult<T1, TriggerFactory, T2, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3>(this CombinedResult<T1, T2, TriggerFactory, T3> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3>(this CombinedResult<T1, T2, T3, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TriggerFactory, T1, T2, T3, T4, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3, T4>(this CombinedResult<TriggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TriggerFactory, T2, T3, T4, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3, T4>(this CombinedResult<T1, TriggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TriggerFactory, T3, T4, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3, T4>(this CombinedResult<T1, T2, TriggerFactory, T3, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TriggerFactory, T4, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TriggerFactory, T4> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TriggerFactory, InnerTriggerPredicateFactory> WithPredicate<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TriggerFactory> combinedResult, Action<Humidifier.Glue.TriggerTypes.Predicate> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPredicate(combinedResult.T5, subFactoryAction));
}
