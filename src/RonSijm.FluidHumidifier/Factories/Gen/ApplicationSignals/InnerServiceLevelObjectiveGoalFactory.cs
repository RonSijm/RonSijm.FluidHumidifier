// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveGoalFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal>
{

    internal InnerServiceLevelObjectiveIntervalFactory IntervalFactory { get; set; }

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal Create()
    {
        var goalResult = CreateGoal();
        factoryAction?.Invoke(goalResult);

        return goalResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal CreateGoal()
    {
        var goalResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal();

        return goalResult;
    }
    public override void CreateChildren(Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Goal result)
    {
        base.CreateChildren(result);

        result.Interval ??= IntervalFactory?.Build();
    }

} // End Of Class

public static class InnerServiceLevelObjectiveGoalFactoryExtensions
{
    public static CombinedResult<InnerServiceLevelObjectiveGoalFactory, InnerServiceLevelObjectiveIntervalFactory> WithInterval(this InnerServiceLevelObjectiveGoalFactory parentFactory, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null)
    {
        parentFactory.IntervalFactory = new InnerServiceLevelObjectiveIntervalFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IntervalFactory);
    }

    public static CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1>(this CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, WithInterval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1>(this CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, WithInterval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2>(this CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2>(this CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2, T3, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3>(this CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2, T3, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3>(this CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory, T3, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory, T3> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveGoalFactory, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveGoalFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2, T3, T4, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3, T4>(this CombinedResult<InnerServiceLevelObjectiveGoalFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2, T3, T4, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3, T4>(this CombinedResult<T1, InnerServiceLevelObjectiveGoalFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory, T3, T4, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerServiceLevelObjectiveGoalFactory, T3, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveGoalFactory, T4, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerServiceLevelObjectiveGoalFactory, T4> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveGoalFactory, InnerServiceLevelObjectiveIntervalFactory> WithInterval<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerServiceLevelObjectiveGoalFactory> combinedResult, Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.Interval> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInterval(combinedResult.T5, subFactoryAction));
}
