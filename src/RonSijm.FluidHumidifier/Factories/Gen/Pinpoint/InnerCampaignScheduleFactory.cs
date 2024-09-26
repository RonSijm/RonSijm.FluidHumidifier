// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerCampaignScheduleFactory(Action<Humidifier.Pinpoint.CampaignTypes.Schedule> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.CampaignTypes.Schedule>
{

    internal InnerCampaignQuietTimeFactory QuietTimeFactory { get; set; }

    internal InnerCampaignCampaignEventFilterFactory EventFilterFactory { get; set; }

    protected override Humidifier.Pinpoint.CampaignTypes.Schedule Create()
    {
        var scheduleResult = CreateSchedule();
        factoryAction?.Invoke(scheduleResult);

        return scheduleResult;
    }

    private Humidifier.Pinpoint.CampaignTypes.Schedule CreateSchedule()
    {
        var scheduleResult = new Humidifier.Pinpoint.CampaignTypes.Schedule();

        return scheduleResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.CampaignTypes.Schedule result)
    {
        base.CreateChildren(result);

        result.QuietTime ??= QuietTimeFactory?.Build();
        result.EventFilter ??= EventFilterFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignScheduleFactoryExtensions
{
    public static CombinedResult<InnerCampaignScheduleFactory, InnerCampaignQuietTimeFactory> WithQuietTime(this InnerCampaignScheduleFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null)
    {
        parentFactory.QuietTimeFactory = new InnerCampaignQuietTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QuietTimeFactory);
    }

    public static CombinedResult<InnerCampaignScheduleFactory, InnerCampaignCampaignEventFilterFactory> WithEventFilter(this InnerCampaignScheduleFactory parentFactory, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null)
    {
        parentFactory.EventFilterFactory = new InnerCampaignCampaignEventFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventFilterFactory);
    }

    public static CombinedResult<InnerCampaignScheduleFactory, T1, InnerCampaignQuietTimeFactory> WithQuietTime<T1>(this CombinedResult<InnerCampaignScheduleFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, InnerCampaignQuietTimeFactory> WithQuietTime<T1>(this CombinedResult<T1, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, T4, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, T4, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, T4, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, T4, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignScheduleFactory, InnerCampaignQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1>(this CombinedResult<InnerCampaignScheduleFactory, T1> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1>(this CombinedResult<T1, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, T4, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<InnerCampaignScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, T4, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, T4, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, T4, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignScheduleFactory, T4> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignScheduleFactory, InnerCampaignCampaignEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignScheduleFactory> combinedResult, Action<Humidifier.Pinpoint.CampaignTypes.CampaignEventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T5, subFactoryAction));
}
