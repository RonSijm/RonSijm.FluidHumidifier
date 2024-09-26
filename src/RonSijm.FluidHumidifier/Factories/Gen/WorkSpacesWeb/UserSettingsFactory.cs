// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class UserSettingsFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.UserSettings> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.UserSettings>(resourceName)
{

    internal InnerUserSettingsCookieSynchronizationConfigurationFactory CookieSynchronizationConfigurationFactory { get; set; }

    protected override Humidifier.WorkSpacesWeb.UserSettings Create()
    {
        var userSettingsResult = CreateUserSettings();
        factoryAction?.Invoke(userSettingsResult);

        return userSettingsResult;
    }

    private Humidifier.WorkSpacesWeb.UserSettings CreateUserSettings()
    {
        var userSettingsResult = new Humidifier.WorkSpacesWeb.UserSettings
        {
            GivenName = InputResourceName,
        };

        return userSettingsResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.UserSettings result)
    {
        base.CreateChildren(result);

        result.CookieSynchronizationConfiguration ??= CookieSynchronizationConfigurationFactory?.Build();
    }

} // End Of Class

public static class UserSettingsFactoryExtensions
{
    public static CombinedResult<UserSettingsFactory, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration(this UserSettingsFactory parentFactory, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null)
    {
        parentFactory.CookieSynchronizationConfigurationFactory = new InnerUserSettingsCookieSynchronizationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CookieSynchronizationConfigurationFactory);
    }

    public static CombinedResult<UserSettingsFactory, T1, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1>(this CombinedResult<UserSettingsFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserSettingsFactory, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1>(this CombinedResult<T1, UserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<UserSettingsFactory, T1, T2, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2>(this CombinedResult<UserSettingsFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserSettingsFactory, T2, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2>(this CombinedResult<T1, UserSettingsFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserSettingsFactory, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2>(this CombinedResult<T1, T2, UserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<UserSettingsFactory, T1, T2, T3, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<UserSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserSettingsFactory, T2, T3, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, UserSettingsFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserSettingsFactory, T3, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, UserSettingsFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserSettingsFactory, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, UserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<UserSettingsFactory, T1, T2, T3, T4, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<UserSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, UserSettingsFactory, T2, T3, T4, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, UserSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, UserSettingsFactory, T3, T4, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, UserSettingsFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, UserSettingsFactory, T4, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, UserSettingsFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, UserSettingsFactory, InnerUserSettingsCookieSynchronizationConfigurationFactory> WithCookieSynchronizationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, UserSettingsFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.UserSettingsTypes.CookieSynchronizationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCookieSynchronizationConfiguration(combinedResult.T5, subFactoryAction));
}
