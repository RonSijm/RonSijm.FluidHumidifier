// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class InnerLicenseServerEndpointServerSettingsFactory(Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings>
{

    internal InnerLicenseServerEndpointRdsSalSettingsFactory RdsSalSettingsFactory { get; set; }

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings Create()
    {
        var serverSettingsResult = CreateServerSettings();
        factoryAction?.Invoke(serverSettingsResult);

        return serverSettingsResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings CreateServerSettings()
    {
        var serverSettingsResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings();

        return serverSettingsResult;
    }
    public override void CreateChildren(Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.ServerSettings result)
    {
        base.CreateChildren(result);

        result.RdsSalSettings ??= RdsSalSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerLicenseServerEndpointServerSettingsFactoryExtensions
{
    public static CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings(this InnerLicenseServerEndpointServerSettingsFactory parentFactory, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null)
    {
        parentFactory.RdsSalSettingsFactory = new InnerLicenseServerEndpointRdsSalSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RdsSalSettingsFactory);
    }

    public static CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1>(this CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1>(this CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2>(this CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2>(this CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2>(this CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3>(this CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3>(this CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory, T3, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointServerSettingsFactory, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2, T3, T4, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3, T4>(this CombinedResult<InnerLicenseServerEndpointServerSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2, T3, T4, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerLicenseServerEndpointServerSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory, T3, T4, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLicenseServerEndpointServerSettingsFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointServerSettingsFactory, T4, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointServerSettingsFactory, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointServerSettingsFactory, InnerLicenseServerEndpointRdsSalSettingsFactory> WithRdsSalSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointServerSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalSettings(combinedResult.T5, subFactoryAction).T2);
}
