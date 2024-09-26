// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Scheduler;

public class ScheduleFactory(string resourceName = null, Action<Humidifier.Scheduler.Schedule> factoryAction = null) : ResourceFactory<Humidifier.Scheduler.Schedule>(resourceName)
{

    internal InnerScheduleTargetFactory TargetFactory { get; set; }

    internal InnerScheduleFlexibleTimeWindowFactory FlexibleTimeWindowFactory { get; set; }

    protected override Humidifier.Scheduler.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.Scheduler.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.Scheduler.Schedule
        {
            GivenName = InputResourceName,
        };

        return scheduleResult;
    }
    public override void CreateChildren(Humidifier.Scheduler.Schedule result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
        result.FlexibleTimeWindow ??= FlexibleTimeWindowFactory?.Build();
    }

} // End Of Class

public static class ScheduleFactoryExtensions
{
    public static CombinedResult<ScheduleFactory, InnerScheduleTargetFactory> WithTarget(this ScheduleFactory parentFactory, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerScheduleTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<ScheduleFactory, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow(this ScheduleFactory parentFactory, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null)
    {
        parentFactory.FlexibleTimeWindowFactory = new InnerScheduleFlexibleTimeWindowFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlexibleTimeWindowFactory);
    }

    public static CombinedResult<ScheduleFactory, T1, InnerScheduleTargetFactory> WithTarget<T1>(this CombinedResult<ScheduleFactory, T1> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, InnerScheduleTargetFactory> WithTarget<T1>(this CombinedResult<T1, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, InnerScheduleTargetFactory> WithTarget<T1, T2>(this CombinedResult<ScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, InnerScheduleTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, ScheduleFactory, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, InnerScheduleTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, T3, InnerScheduleTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<ScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, T3, InnerScheduleTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, ScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, T3, InnerScheduleTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, ScheduleFactory, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduleFactory, InnerScheduleTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, T3, T4, InnerScheduleTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<ScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, T3, T4, InnerScheduleTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, ScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, T3, T4, InnerScheduleTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduleFactory, T4, InnerScheduleTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduleFactory, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScheduleFactory, InnerScheduleTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.Target> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1>(this CombinedResult<ScheduleFactory, T1> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1>(this CombinedResult<T1, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2>(this CombinedResult<ScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2>(this CombinedResult<T1, ScheduleFactory, T2> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2>(this CombinedResult<T1, T2, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, T3, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3>(this CombinedResult<ScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, T3, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3>(this CombinedResult<T1, ScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, T3, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3>(this CombinedResult<T1, T2, ScheduleFactory, T3> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduleFactory, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ScheduleFactory, T1, T2, T3, T4, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3, T4>(this CombinedResult<ScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ScheduleFactory, T2, T3, T4, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3, T4>(this CombinedResult<T1, ScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ScheduleFactory, T3, T4, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ScheduleFactory, T4, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduleFactory, T4> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ScheduleFactory, InnerScheduleFlexibleTimeWindowFactory> WithFlexibleTimeWindow<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduleFactory> combinedResult, Action<Humidifier.Scheduler.ScheduleTypes.FlexibleTimeWindow> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlexibleTimeWindow(combinedResult.T5, subFactoryAction));
}
