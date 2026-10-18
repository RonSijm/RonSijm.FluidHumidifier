// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCM;

public class ScheduledReportFactory(string resourceName = null, Action<Humidifier.BCM.ScheduledReport> factoryAction = null) : ResourceFactory<Humidifier.BCM.ScheduledReport>(resourceName)
{

    internal InnerScheduledReportScheduleConfigFactory ScheduleConfigFactory { get; set; }

    internal InnerScheduledReportDateTimeRangeFactory WidgetDateRangeOverrideFactory { get; set; }

    protected override Humidifier.BCM.ScheduledReport Create()
    {
        var scheduledReportResult = CreateScheduledReport();
        factoryAction?.Invoke(scheduledReportResult);

        return scheduledReportResult;
    }

    private Humidifier.BCM.ScheduledReport CreateScheduledReport()
    {
        var scheduledReportResult = new Humidifier.BCM.ScheduledReport
        {
            GivenName = InputResourceName,
        };

        return scheduledReportResult;
    }
    public override void CreateChildren(Humidifier.BCM.ScheduledReport result)
    {
        base.CreateChildren(result);

        result.ScheduleConfig ??= ScheduleConfigFactory?.Build();
        result.WidgetDateRangeOverride ??= WidgetDateRangeOverrideFactory?.Build();
    }

} // End Of Class

public static class ScheduledReportFactoryExtensions
{
    public static CombinedResult<ScheduledReportFactory, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig(this ScheduledReportFactory parentFactory, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null)
    {
        parentFactory.ScheduleConfigFactory = new InnerScheduledReportScheduleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleConfigFactory);
    }

    public static CombinedResult<ScheduledReportFactory, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride(this ScheduledReportFactory parentFactory, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null)
    {
        parentFactory.WidgetDateRangeOverrideFactory = new InnerScheduledReportDateTimeRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.WidgetDateRangeOverrideFactory);
    }

    public static CombinedResult<ScheduledReportFactory, T1, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1>(this CombinedResult<ScheduledReportFactory, T1> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1>(this CombinedResult<T1, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<ScheduledReportFactory, T1, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<T1, ScheduledReportFactory, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2>(this CombinedResult<T1, T2, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, T3, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<ScheduledReportFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, T3, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, ScheduledReportFactory, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, T3, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, ScheduledReportFactory, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledReportFactory, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, T3, T4, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<ScheduledReportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, T3, T4, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, ScheduledReportFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, T3, T4, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduledReportFactory, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledReportFactory, T4, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduledReportFactory, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ScheduledReportFactory, InnerScheduledReportScheduleConfigFactory> WithScheduleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.ScheduleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScheduleConfig(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1>(this CombinedResult<ScheduledReportFactory, T1> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1>(this CombinedResult<T1, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2>(this CombinedResult<ScheduledReportFactory, T1, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2>(this CombinedResult<T1, ScheduledReportFactory, T2> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2>(this CombinedResult<T1, T2, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, T3, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3>(this CombinedResult<ScheduledReportFactory, T1, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, T3, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3>(this CombinedResult<T1, ScheduledReportFactory, T2, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, T3, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3>(this CombinedResult<T1, T2, ScheduledReportFactory, T3> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledReportFactory, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3>(this CombinedResult<T1, T2, T3, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ScheduledReportFactory, T1, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3, T4>(this CombinedResult<ScheduledReportFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ScheduledReportFactory, T2, T3, T4, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3, T4>(this CombinedResult<T1, ScheduledReportFactory, T2, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ScheduledReportFactory, T3, T4, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, ScheduledReportFactory, T3, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ScheduledReportFactory, T4, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ScheduledReportFactory, T4> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ScheduledReportFactory, InnerScheduledReportDateTimeRangeFactory> WithWidgetDateRangeOverride<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ScheduledReportFactory> combinedResult, Action<Humidifier.BCM.ScheduledReportTypes.DateTimeRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithWidgetDateRangeOverride(combinedResult.T5, subFactoryAction).T2);
}
