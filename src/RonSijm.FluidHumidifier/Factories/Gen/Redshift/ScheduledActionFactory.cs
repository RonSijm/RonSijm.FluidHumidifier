// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Redshift;

public class ScheduledActionFactory(string resourceName = null, Action<Humidifier.Redshift.ScheduledAction> factoryAction = null) : ResourceFactory<Humidifier.Redshift.ScheduledAction>(resourceName)
{

    internal InnerScheduledActionScheduledActionTypeFactory TargetActionFactory { get; set; }

    protected override Humidifier.Redshift.ScheduledAction Create()
    {
        var scheduledActionResult = CreateScheduledAction();
        factoryAction?.Invoke(scheduledActionResult);

        return scheduledActionResult;
    }

    private Humidifier.Redshift.ScheduledAction CreateScheduledAction()
    {
        var scheduledActionResult = new Humidifier.Redshift.ScheduledAction
        {
            GivenName = InputResourceName,
        };

        return scheduledActionResult;
    }
    public override void CreateChildren(Humidifier.Redshift.ScheduledAction result)
    {
        base.CreateChildren(result);

        result.TargetAction ??= TargetActionFactory?.Build();
    }

} // End Of Class

public static class ScheduledActionFactoryExtensions
{
    public static CombinedResult<ScheduledActionFactory, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction(this ScheduledActionFactory parentFactory, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null)
    {
        parentFactory.TargetActionFactory = new InnerScheduledActionScheduledActionTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetActionFactory);
    }

    public static CombinedResult<ScheduledActionFactory, T1, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1>(this CombinedResult<ScheduledActionFactory, T1> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduledActionFactory, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1>(this CombinedResult<T1, ScheduledActionFactory> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, WithTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScheduledActionFactory, T1, T2, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2>(this CombinedResult<ScheduledActionFactory, T1, T2> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduledActionFactory, T2, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2>(this CombinedResult<T1, ScheduledActionFactory, T2> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduledActionFactory, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2>(this CombinedResult<T1, T2, ScheduledActionFactory> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScheduledActionFactory, T1, T2, T3, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3>(this CombinedResult<ScheduledActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduledActionFactory, T2, T3, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3>(this CombinedResult<T1, ScheduledActionFactory, T2, T3> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduledActionFactory, T3, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3>(this CombinedResult<T1, T2, ScheduledActionFactory, T3> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduledActionFactory, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduledActionFactory> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScheduledActionFactory, T1, T2, T3, T4, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3, T4>(this CombinedResult<ScheduledActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduledActionFactory, T2, T3, T4, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, ScheduledActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduledActionFactory, T3, T4, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduledActionFactory, T3, T4> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduledActionFactory, T4, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduledActionFactory, T4> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScheduledActionFactory, InnerScheduledActionScheduledActionTypeFactory> WithTargetAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduledActionFactory> combinedResult, Action<Humidifier.Redshift.ScheduledActionTypes.ScheduledActionType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTargetAction(combinedResult.T5, subFactoryAction));
}
