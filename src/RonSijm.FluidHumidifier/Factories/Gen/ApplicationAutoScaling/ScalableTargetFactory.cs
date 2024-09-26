// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class ScalableTargetFactory(string resourceName = null, Action<Humidifier.ApplicationAutoScaling.ScalableTarget> factoryAction = null) : ResourceFactory<Humidifier.ApplicationAutoScaling.ScalableTarget>(resourceName)
{

    internal List<InnerScalableTargetScheduledActionFactory> ScheduledActionsFactories { get; set; } = [];

    internal InnerScalableTargetSuspendedStateFactory SuspendedStateFactory { get; set; }

    protected override Humidifier.ApplicationAutoScaling.ScalableTarget Create()
    {
        var scalableTargetResult = CreateScalableTarget();
        factoryAction?.Invoke(scalableTargetResult);

        return scalableTargetResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalableTarget CreateScalableTarget()
    {
        var scalableTargetResult = new Humidifier.ApplicationAutoScaling.ScalableTarget
        {
            GivenName = InputResourceName,
        };

        return scalableTargetResult;
    }
    public override void CreateChildren(Humidifier.ApplicationAutoScaling.ScalableTarget result)
    {
        base.CreateChildren(result);

        result.ScheduledActions = ScheduledActionsFactories.Any() ? ScheduledActionsFactories.Select(x => x.Build()).ToList() : null;
        result.SuspendedState ??= SuspendedStateFactory?.Build();
    }

} // End Of Class

public static class ScalableTargetFactoryExtensions
{
    public static CombinedResult<ScalableTargetFactory, InnerScalableTargetScheduledActionFactory> WithScheduledActions(this ScalableTargetFactory parentFactory, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null)
    {
        var factory = new InnerScalableTargetScheduledActionFactory(subFactoryAction);
        parentFactory.ScheduledActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ScalableTargetFactory, InnerScalableTargetSuspendedStateFactory> WithSuspendedState(this ScalableTargetFactory parentFactory, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null)
    {
        parentFactory.SuspendedStateFactory = new InnerScalableTargetSuspendedStateFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SuspendedStateFactory);
    }

    public static CombinedResult<ScalableTargetFactory, T1, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1>(this CombinedResult<ScalableTargetFactory, T1> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduledActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1>(this CombinedResult<T1, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduledActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2>(this CombinedResult<ScalableTargetFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2>(this CombinedResult<T1, ScalableTargetFactory, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2>(this CombinedResult<T1, T2, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, T3, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3>(this CombinedResult<ScalableTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, T3, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3>(this CombinedResult<T1, ScalableTargetFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, T3, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3>(this CombinedResult<T1, T2, ScalableTargetFactory, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalableTargetFactory, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, T3, T4, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3, T4>(this CombinedResult<ScalableTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, T3, T4, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3, T4>(this CombinedResult<T1, ScalableTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, T3, T4, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScalableTargetFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalableTargetFactory, T4, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScalableTargetFactory, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScalableTargetFactory, InnerScalableTargetScheduledActionFactory> WithScheduledActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduledActions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1>(this CombinedResult<ScalableTargetFactory, T1> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuspendedState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1>(this CombinedResult<T1, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, WithSuspendedState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2>(this CombinedResult<ScalableTargetFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2>(this CombinedResult<T1, ScalableTargetFactory, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2>(this CombinedResult<T1, T2, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, T3, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3>(this CombinedResult<ScalableTargetFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, T3, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3>(this CombinedResult<T1, ScalableTargetFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, T3, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3>(this CombinedResult<T1, T2, ScalableTargetFactory, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalableTargetFactory, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScalableTargetFactory, T1, T2, T3, T4, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3, T4>(this CombinedResult<ScalableTargetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScalableTargetFactory, T2, T3, T4, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3, T4>(this CombinedResult<T1, ScalableTargetFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScalableTargetFactory, T3, T4, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScalableTargetFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScalableTargetFactory, T4, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScalableTargetFactory, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScalableTargetFactory, InnerScalableTargetSuspendedStateFactory> WithSuspendedState<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScalableTargetFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.SuspendedState> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSuspendedState(combinedResult.T5, subFactoryAction));
}
