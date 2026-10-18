// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class AppInstanceUserFactory(string resourceName = null, Action<Humidifier.Chime.AppInstanceUser> factoryAction = null) : ResourceFactory<Humidifier.Chime.AppInstanceUser>(resourceName)
{

    internal InnerAppInstanceUserExpirationSettingsFactory ExpirationSettingsFactory { get; set; }

    protected override Humidifier.Chime.AppInstanceUser Create()
    {
        var appInstanceUserResult = CreateAppInstanceUser();
        factoryAction?.Invoke(appInstanceUserResult);

        return appInstanceUserResult;
    }

    private Humidifier.Chime.AppInstanceUser CreateAppInstanceUser()
    {
        var appInstanceUserResult = new Humidifier.Chime.AppInstanceUser
        {
            GivenName = InputResourceName,
        };

        return appInstanceUserResult;
    }
    public override void CreateChildren(Humidifier.Chime.AppInstanceUser result)
    {
        base.CreateChildren(result);

        result.ExpirationSettings ??= ExpirationSettingsFactory?.Build();
    }

} // End Of Class

public static class AppInstanceUserFactoryExtensions
{
    public static CombinedResult<AppInstanceUserFactory, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings(this AppInstanceUserFactory parentFactory, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null)
    {
        parentFactory.ExpirationSettingsFactory = new InnerAppInstanceUserExpirationSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExpirationSettingsFactory);
    }

    public static CombinedResult<AppInstanceUserFactory, T1, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1>(this CombinedResult<AppInstanceUserFactory, T1> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceUserFactory, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1>(this CombinedResult<T1, AppInstanceUserFactory> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AppInstanceUserFactory, T1, T2, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<AppInstanceUserFactory, T1, T2> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceUserFactory, T2, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<T1, AppInstanceUserFactory, T2> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceUserFactory, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2>(this CombinedResult<T1, T2, AppInstanceUserFactory> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AppInstanceUserFactory, T1, T2, T3, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<AppInstanceUserFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceUserFactory, T2, T3, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, AppInstanceUserFactory, T2, T3> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceUserFactory, T3, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, T2, AppInstanceUserFactory, T3> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppInstanceUserFactory, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, AppInstanceUserFactory> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AppInstanceUserFactory, T1, T2, T3, T4, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<AppInstanceUserFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AppInstanceUserFactory, T2, T3, T4, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, AppInstanceUserFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AppInstanceUserFactory, T3, T4, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, AppInstanceUserFactory, T3, T4> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AppInstanceUserFactory, T4, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AppInstanceUserFactory, T4> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AppInstanceUserFactory, InnerAppInstanceUserExpirationSettingsFactory> WithExpirationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AppInstanceUserFactory> combinedResult, Action<Humidifier.Chime.AppInstanceUserTypes.ExpirationSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExpirationSettings(combinedResult.T5, subFactoryAction).T2);
}
