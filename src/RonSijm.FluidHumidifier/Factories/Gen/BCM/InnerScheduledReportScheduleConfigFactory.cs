// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class InnerScheduledReportScheduleConfigFactory(Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> factoryAction = null) : SubResourceFactory<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig>
{

    internal InnerScheduledReportSchedulePeriodFactory SchedulePeriodFactory { get; set; }

    protected override Humidifier.BCM.ScheduledReportTypes.ScheduleConfig Create()
    {
        var scheduleConfigResult = CreateScheduleConfig();
        factoryAction?.Invoke(scheduleConfigResult);

        return scheduleConfigResult;
    }

    private Humidifier.BCM.ScheduledReportTypes.ScheduleConfig CreateScheduleConfig()
    {
        var scheduleConfigResult = new Humidifier.BCM.ScheduledReportTypes.ScheduleConfig();

        return scheduleConfigResult;
    }
    public override void CreateChildren(Humidifier.BCM.ScheduledReportTypes.ScheduleConfig result)
    {
        base.CreateChildren(result);

        result.SchedulePeriod ??= SchedulePeriodFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledReportScheduleConfigFactoryExtensions
{
    public static CombinedResult<InnerScheduledReportScheduleConfigFactory, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod(this InnerScheduledReportScheduleConfigFactory parentFactory, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null)
    {
        parentFactory.SchedulePeriodFactory = new InnerScheduledReportSchedulePeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SchedulePeriodFactory);
    }

    public static CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1>(this CombinedResult<InnerScheduledReportScheduleConfigFactory, T1> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1>(this CombinedResult<T1, InnerScheduledReportScheduleConfigFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2>(this CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2>(this CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2>(this CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2, T3, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3>(this CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2, T3, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3>(this CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory, T3, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportScheduleConfigFactory, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledReportScheduleConfigFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2, T3, T4, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3, T4>(this CombinedResult<InnerScheduledReportScheduleConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2, T3, T4, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledReportScheduleConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory, T3, T4, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledReportScheduleConfigFactory, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerScheduledReportScheduleConfigFactory, T4, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledReportScheduleConfigFactory, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledReportScheduleConfigFactory, InnerScheduledReportSchedulePeriodFactory> WithSchedulePeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledReportScheduleConfigFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.SchedulePeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedulePeriod(combinedResult.T5, subFactoryAction).T2);
}
