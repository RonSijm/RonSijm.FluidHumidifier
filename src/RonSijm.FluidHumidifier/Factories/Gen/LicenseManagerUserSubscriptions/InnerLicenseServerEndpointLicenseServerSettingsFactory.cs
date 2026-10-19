// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class InnerLicenseServerEndpointLicenseServerSettingsFactory(Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings>
{

    internal InnerLicenseServerEndpointServerSettingsFactory ServerSettingsFactory { get; set; }

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings Create()
    {
        var licenseServerSettingsResult = CreateLicenseServerSettings();
        factoryAction?.Invoke(licenseServerSettingsResult);

        return licenseServerSettingsResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings CreateLicenseServerSettings()
    {
        var licenseServerSettingsResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings();

        return licenseServerSettingsResult;
    }
    public override void CreateChildren(Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings result)
    {
        base.CreateChildren(result);

        result.ServerSettings ??= ServerSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerLicenseServerEndpointLicenseServerSettingsFactoryExtensions
{
    public static CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings(this InnerLicenseServerEndpointLicenseServerSettingsFactory parentFactory, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null)
    {
        parentFactory.ServerSettingsFactory = new InnerLicenseServerEndpointServerSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServerSettingsFactory);
    }

    public static CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1>(this CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1>(this CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2>(this CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2>(this CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2>(this CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2, T3, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3>(this CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2, T3, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3>(this CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory, T3, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2, T3, T4, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3, T4>(this CombinedResult<InnerLicenseServerEndpointLicenseServerSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2, T3, T4, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerLicenseServerEndpointLicenseServerSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory, T3, T4, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory, T4, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory, InnerLicenseServerEndpointServerSettingsFactory> WithServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServerSettings(combinedResult.T5, subFactoryAction).T2);
}
