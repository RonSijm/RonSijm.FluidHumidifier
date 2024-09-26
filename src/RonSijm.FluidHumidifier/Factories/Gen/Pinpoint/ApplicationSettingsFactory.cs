// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class ApplicationSettingsFactory(string resourceName = null, Action<Humidifier.Pinpoint.ApplicationSettings> factoryAction = null) : ResourceFactory<Humidifier.Pinpoint.ApplicationSettings>(resourceName)
{

    internal InnerApplicationSettingsQuietTimeFactory QuietTimeFactory { get; set; }

    internal InnerApplicationSettingsLimitsFactory LimitsFactory { get; set; }

    internal InnerApplicationSettingsCampaignHookFactory CampaignHookFactory { get; set; }

    protected override Humidifier.Pinpoint.ApplicationSettings Create()
    {
        var applicationSettingsResult = CreateApplicationSettings();
        factoryAction?.Invoke(applicationSettingsResult);

        return applicationSettingsResult;
    }

    private Humidifier.Pinpoint.ApplicationSettings CreateApplicationSettings()
    {
        var applicationSettingsResult = new Humidifier.Pinpoint.ApplicationSettings
        {
            GivenName = InputResourceName,
        };

        return applicationSettingsResult;
    }
    public override void CreateChildren(Humidifier.Pinpoint.ApplicationSettings result)
    {
        base.CreateChildren(result);

        result.QuietTime ??= QuietTimeFactory?.Build();
        result.Limits ??= LimitsFactory?.Build();
        result.CampaignHook ??= CampaignHookFactory?.Build();
    }

} // End Of Class

public static class ApplicationSettingsFactoryExtensions
{
    public static CombinedResult<ApplicationSettingsFactory, InnerApplicationSettingsQuietTimeFactory> WithQuietTime(this ApplicationSettingsFactory parentFactory, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null)
    {
        parentFactory.QuietTimeFactory = new InnerApplicationSettingsQuietTimeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.QuietTimeFactory);
    }

    public static CombinedResult<ApplicationSettingsFactory, InnerApplicationSettingsLimitsFactory> WithLimits(this ApplicationSettingsFactory parentFactory, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null)
    {
        parentFactory.LimitsFactory = new InnerApplicationSettingsLimitsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LimitsFactory);
    }

    public static CombinedResult<ApplicationSettingsFactory, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook(this ApplicationSettingsFactory parentFactory, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null)
    {
        parentFactory.CampaignHookFactory = new InnerApplicationSettingsCampaignHookFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CampaignHookFactory);
    }

    public static CombinedResult<ApplicationSettingsFactory, T1, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1>(this CombinedResult<ApplicationSettingsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1>(this CombinedResult<T1, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<ApplicationSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<T1, ApplicationSettingsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2>(this CombinedResult<T1, T2, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory, InnerApplicationSettingsQuietTimeFactory> WithQuietTime<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.QuietTime> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithQuietTime(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, InnerApplicationSettingsLimitsFactory> WithLimits<T1>(this CombinedResult<ApplicationSettingsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, WithLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, InnerApplicationSettingsLimitsFactory> WithLimits<T1>(this CombinedResult<T1, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, WithLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2>(this CombinedResult<ApplicationSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2>(this CombinedResult<T1, ApplicationSettingsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2>(this CombinedResult<T1, T2, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3, T4>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory, InnerApplicationSettingsLimitsFactory> WithLimits<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.Limits> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLimits(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1>(this CombinedResult<ApplicationSettingsFactory, T1> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithCampaignHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1>(this CombinedResult<T1, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, WithCampaignHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2>(this CombinedResult<ApplicationSettingsFactory, T1, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2>(this CombinedResult<T1, ApplicationSettingsFactory, T2> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2>(this CombinedResult<T1, T2, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3, T4>(this CombinedResult<ApplicationSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3, T4>(this CombinedResult<T1, ApplicationSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, ApplicationSettingsFactory, T3, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ApplicationSettingsFactory, T4> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory, InnerApplicationSettingsCampaignHookFactory> WithCampaignHook<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ApplicationSettingsFactory> combinedResult, Action<Humidifier.Pinpoint.ApplicationSettingsTypes.CampaignHook> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCampaignHook(combinedResult.T5, subFactoryAction));
}
