// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationAutoScaling;

public class InnerScalableTargetScheduledActionFactory(Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction>
{

    internal InnerScalableTargetScalableTargetActionFactory ScalableTargetActionFactory { get; set; }

    protected override Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction Create()
    {
        var scheduledActionResult = CreateScheduledAction();
        factoryAction?.Invoke(scheduledActionResult);

        return scheduledActionResult;
    }

    private Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction CreateScheduledAction()
    {
        var scheduledActionResult = new Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction();

        return scheduledActionResult;
    }
    public override void CreateChildren(Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScheduledAction result)
    {
        base.CreateChildren(result);

        result.ScalableTargetAction ??= ScalableTargetActionFactory?.Build();
    }

} // End Of Class

public static class InnerScalableTargetScheduledActionFactoryExtensions
{
    public static CombinedResult<InnerScalableTargetScheduledActionFactory, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction(this InnerScalableTargetScheduledActionFactory parentFactory, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null)
    {
        parentFactory.ScalableTargetActionFactory = new InnerScalableTargetScalableTargetActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScalableTargetActionFactory);
    }

    public static CombinedResult<InnerScalableTargetScheduledActionFactory, T1, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1>(this CombinedResult<InnerScalableTargetScheduledActionFactory, T1> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalableTargetScheduledActionFactory, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1>(this CombinedResult<T1, InnerScalableTargetScheduledActionFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2>(this CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2>(this CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2>(this CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2, T3, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3>(this CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2, T3, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3>(this CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory, T3, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory, T3> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalableTargetScheduledActionFactory, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScalableTargetScheduledActionFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2, T3, T4, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3, T4>(this CombinedResult<InnerScalableTargetScheduledActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2, T3, T4, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerScalableTargetScheduledActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory, T3, T4, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScalableTargetScheduledActionFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScalableTargetScheduledActionFactory, T4, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScalableTargetScheduledActionFactory, T4> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScalableTargetScheduledActionFactory, InnerScalableTargetScalableTargetActionFactory> WithScalableTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScalableTargetScheduledActionFactory> combinedResult, Action<Humidifier.ApplicationAutoScaling.ScalableTargetTypes.ScalableTargetAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScalableTargetAction(combinedResult.T5, subFactoryAction));
}
