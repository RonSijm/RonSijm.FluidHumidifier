// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class LicenseServerEndpointFactory(string resourceName = null, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint> factoryAction = null) : ResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint>(resourceName)
{

    internal InnerLicenseServerEndpointLicenseServerSettingsFactory LicenseServerSettingsFactory { get; set; }

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint Create()
    {
        var licenseServerEndpointResult = CreateLicenseServerEndpoint();
        factoryAction?.Invoke(licenseServerEndpointResult);

        return licenseServerEndpointResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint CreateLicenseServerEndpoint()
    {
        var licenseServerEndpointResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint
        {
            GivenName = InputResourceName,
        };

        return licenseServerEndpointResult;
    }
    public override void CreateChildren(Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpoint result)
    {
        base.CreateChildren(result);

        result.LicenseServerSettings ??= LicenseServerSettingsFactory?.Build();
    }

} // End Of Class

public static class LicenseServerEndpointFactoryExtensions
{
    public static CombinedResult<LicenseServerEndpointFactory, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings(this LicenseServerEndpointFactory parentFactory, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null)
    {
        parentFactory.LicenseServerSettingsFactory = new InnerLicenseServerEndpointLicenseServerSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LicenseServerSettingsFactory);
    }

    public static CombinedResult<LicenseServerEndpointFactory, T1, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1>(this CombinedResult<LicenseServerEndpointFactory, T1> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseServerEndpointFactory, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1>(this CombinedResult<T1, LicenseServerEndpointFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<LicenseServerEndpointFactory, T1, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2>(this CombinedResult<LicenseServerEndpointFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseServerEndpointFactory, T2, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2>(this CombinedResult<T1, LicenseServerEndpointFactory, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseServerEndpointFactory, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2>(this CombinedResult<T1, T2, LicenseServerEndpointFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<LicenseServerEndpointFactory, T1, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3>(this CombinedResult<LicenseServerEndpointFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseServerEndpointFactory, T2, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3>(this CombinedResult<T1, LicenseServerEndpointFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseServerEndpointFactory, T3, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3>(this CombinedResult<T1, T2, LicenseServerEndpointFactory, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseServerEndpointFactory, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, LicenseServerEndpointFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<LicenseServerEndpointFactory, T1, T2, T3, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3, T4>(this CombinedResult<LicenseServerEndpointFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, LicenseServerEndpointFactory, T2, T3, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, LicenseServerEndpointFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, LicenseServerEndpointFactory, T3, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, LicenseServerEndpointFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, LicenseServerEndpointFactory, T4, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LicenseServerEndpointFactory, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, LicenseServerEndpointFactory, InnerLicenseServerEndpointLicenseServerSettingsFactory> WithLicenseServerSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LicenseServerEndpointFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.LicenseServerSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLicenseServerSettings(combinedResult.T5, subFactoryAction).T2);
}
