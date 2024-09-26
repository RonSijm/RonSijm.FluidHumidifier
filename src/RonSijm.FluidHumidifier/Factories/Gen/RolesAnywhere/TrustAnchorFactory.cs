// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class TrustAnchorFactory(string resourceName = null, Action<Humidifier.RolesAnywhere.TrustAnchor> factoryAction = null) : ResourceFactory<Humidifier.RolesAnywhere.TrustAnchor>(resourceName)
{

    internal List<InnerTrustAnchorNotificationSettingFactory> NotificationSettingsFactories { get; set; } = [];

    internal InnerTrustAnchorSourceFactory SourceFactory { get; set; }

    protected override Humidifier.RolesAnywhere.TrustAnchor Create()
    {
        var trustAnchorResult = CreateTrustAnchor();
        factoryAction?.Invoke(trustAnchorResult);

        return trustAnchorResult;
    }

    private Humidifier.RolesAnywhere.TrustAnchor CreateTrustAnchor()
    {
        var trustAnchorResult = new Humidifier.RolesAnywhere.TrustAnchor
        {
            GivenName = InputResourceName,
        };

        return trustAnchorResult;
    }
    public override void CreateChildren(Humidifier.RolesAnywhere.TrustAnchor result)
    {
        base.CreateChildren(result);

        result.NotificationSettings = NotificationSettingsFactories.Any() ? NotificationSettingsFactories.Select(x => x.Build()).ToList() : null;
        result.Source ??= SourceFactory?.Build();
    }

} // End Of Class

public static class TrustAnchorFactoryExtensions
{
    public static CombinedResult<TrustAnchorFactory, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings(this TrustAnchorFactory parentFactory, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null)
    {
        var factory = new InnerTrustAnchorNotificationSettingFactory(subFactoryAction);
        parentFactory.NotificationSettingsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TrustAnchorFactory, InnerTrustAnchorSourceFactory> WithSource(this TrustAnchorFactory parentFactory, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null)
    {
        parentFactory.SourceFactory = new InnerTrustAnchorSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SourceFactory);
    }

    public static CombinedResult<TrustAnchorFactory, T1, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1>(this CombinedResult<TrustAnchorFactory, T1> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1>(this CombinedResult<T1, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2>(this CombinedResult<TrustAnchorFactory, T1, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2>(this CombinedResult<T1, TrustAnchorFactory, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2>(this CombinedResult<T1, T2, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, T3, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3>(this CombinedResult<TrustAnchorFactory, T1, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, T3, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3>(this CombinedResult<T1, TrustAnchorFactory, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, T3, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3>(this CombinedResult<T1, T2, TrustAnchorFactory, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustAnchorFactory, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, T3, T4, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3, T4>(this CombinedResult<TrustAnchorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, T3, T4, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3, T4>(this CombinedResult<T1, TrustAnchorFactory, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, T3, T4, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrustAnchorFactory, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustAnchorFactory, T4, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrustAnchorFactory, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrustAnchorFactory, InnerTrustAnchorNotificationSettingFactory> WithNotificationSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, InnerTrustAnchorSourceFactory> WithSource<T1>(this CombinedResult<TrustAnchorFactory, T1> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, InnerTrustAnchorSourceFactory> WithSource<T1>(this CombinedResult<T1, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, InnerTrustAnchorSourceFactory> WithSource<T1, T2>(this CombinedResult<TrustAnchorFactory, T1, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, InnerTrustAnchorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, TrustAnchorFactory, T2> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, InnerTrustAnchorSourceFactory> WithSource<T1, T2>(this CombinedResult<T1, T2, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, T3, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<TrustAnchorFactory, T1, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, T3, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, TrustAnchorFactory, T2, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, T3, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, TrustAnchorFactory, T3> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustAnchorFactory, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3>(this CombinedResult<T1, T2, T3, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TrustAnchorFactory, T1, T2, T3, T4, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<TrustAnchorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TrustAnchorFactory, T2, T3, T4, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, TrustAnchorFactory, T2, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TrustAnchorFactory, T3, T4, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, TrustAnchorFactory, T3, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TrustAnchorFactory, T4, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TrustAnchorFactory, T4> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TrustAnchorFactory, InnerTrustAnchorSourceFactory> WithSource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TrustAnchorFactory> combinedResult, Action<Humidifier.RolesAnywhere.TrustAnchorTypes.Source> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSource(combinedResult.T5, subFactoryAction));
}
