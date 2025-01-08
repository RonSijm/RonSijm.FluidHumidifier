// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ConnectCampaignsV2;

public class InnerCampaignTimeWindowFactory(Action<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow> factoryAction = null) : SubResourceFactory<Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow>
{

    internal InnerCampaignOpenHoursFactory OpenHoursFactory { get; set; }

    internal InnerCampaignRestrictedPeriodsFactory RestrictedPeriodsFactory { get; set; }

    protected override Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow Create()
    {
        var timeWindowResult = CreateTimeWindow();
        factoryAction?.Invoke(timeWindowResult);

        return timeWindowResult;
    }

    private Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow CreateTimeWindow()
    {
        var timeWindowResult = new Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow();

        return timeWindowResult;
    }
    public override void CreateChildren(Humidifier.ConnectCampaignsV2.CampaignTypes.TimeWindow result)
    {
        base.CreateChildren(result);

        result.OpenHours ??= OpenHoursFactory?.Build();
        result.RestrictedPeriods ??= RestrictedPeriodsFactory?.Build();
    }

} // End Of Class

public static class InnerCampaignTimeWindowFactoryExtensions
{
    public static CombinedResult<InnerCampaignTimeWindowFactory, InnerCampaignOpenHoursFactory> WithOpenHours(this InnerCampaignTimeWindowFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null)
    {
        parentFactory.OpenHoursFactory = new InnerCampaignOpenHoursFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OpenHoursFactory);
    }

    public static CombinedResult<InnerCampaignTimeWindowFactory, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods(this InnerCampaignTimeWindowFactory parentFactory, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null)
    {
        parentFactory.RestrictedPeriodsFactory = new InnerCampaignRestrictedPeriodsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RestrictedPeriodsFactory);
    }

    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, InnerCampaignOpenHoursFactory> WithOpenHours<T1>(this CombinedResult<InnerCampaignTimeWindowFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenHours(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, InnerCampaignOpenHoursFactory> WithOpenHours<T1>(this CombinedResult<T1, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, WithOpenHours(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, T4, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, T4, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, T4, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, T4, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTimeWindowFactory, InnerCampaignOpenHoursFactory> WithOpenHours<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.OpenHours> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOpenHours(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1>(this CombinedResult<InnerCampaignTimeWindowFactory, T1> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1>(this CombinedResult<T1, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, T4, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3, T4>(this CombinedResult<InnerCampaignTimeWindowFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, T4, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3, T4>(this CombinedResult<T1, InnerCampaignTimeWindowFactory, T2, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, T4, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCampaignTimeWindowFactory, T3, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, T4, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCampaignTimeWindowFactory, T4> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCampaignTimeWindowFactory, InnerCampaignRestrictedPeriodsFactory> WithRestrictedPeriods<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCampaignTimeWindowFactory> combinedResult, Action<Humidifier.ConnectCampaignsV2.CampaignTypes.RestrictedPeriods> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRestrictedPeriods(combinedResult.T5, subFactoryAction));
}
