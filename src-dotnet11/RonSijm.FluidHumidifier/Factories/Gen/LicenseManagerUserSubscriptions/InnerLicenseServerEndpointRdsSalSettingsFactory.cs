// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class InnerLicenseServerEndpointRdsSalSettingsFactory(Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings>
{

    internal InnerLicenseServerEndpointCredentialsProviderFactory RdsSalCredentialsProviderFactory { get; set; }

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings Create()
    {
        var rdsSalSettingsResult = CreateRdsSalSettings();
        factoryAction?.Invoke(rdsSalSettingsResult);

        return rdsSalSettingsResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings CreateRdsSalSettings()
    {
        var rdsSalSettingsResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings();

        return rdsSalSettingsResult;
    }
    public override void CreateChildren(Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.RdsSalSettings result)
    {
        base.CreateChildren(result);

        result.RdsSalCredentialsProvider ??= RdsSalCredentialsProviderFactory?.Build();
    }

} // End Of Class

public static class InnerLicenseServerEndpointRdsSalSettingsFactoryExtensions
{
    public static CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider(this InnerLicenseServerEndpointRdsSalSettingsFactory parentFactory, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null)
    {
        parentFactory.RdsSalCredentialsProviderFactory = new InnerLicenseServerEndpointCredentialsProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RdsSalCredentialsProviderFactory);
    }

    public static CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1>(this CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1>(this CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2>(this CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2>(this CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2>(this CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3>(this CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory, T3, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2, T3, T4, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<InnerLicenseServerEndpointRdsSalSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2, T3, T4, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerLicenseServerEndpointRdsSalSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory, T3, T4, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLicenseServerEndpointRdsSalSettingsFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory, T4, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointRdsSalSettingsFactory, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointRdsSalSettingsFactory, InnerLicenseServerEndpointCredentialsProviderFactory> WithRdsSalCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointRdsSalSettingsFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRdsSalCredentialsProvider(combinedResult.T5, subFactoryAction).T2);
}
