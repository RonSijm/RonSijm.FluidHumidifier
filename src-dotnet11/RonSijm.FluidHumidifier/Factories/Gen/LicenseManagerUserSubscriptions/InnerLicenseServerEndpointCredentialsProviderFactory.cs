// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class InnerLicenseServerEndpointCredentialsProviderFactory(Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider>
{

    internal InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory SecretsManagerCredentialsProviderFactory { get; set; }

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider Create()
    {
        var credentialsProviderResult = CreateCredentialsProvider();
        factoryAction?.Invoke(credentialsProviderResult);

        return credentialsProviderResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider CreateCredentialsProvider()
    {
        var credentialsProviderResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider();

        return credentialsProviderResult;
    }
    public override void CreateChildren(Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.CredentialsProvider result)
    {
        base.CreateChildren(result);

        result.SecretsManagerCredentialsProvider ??= SecretsManagerCredentialsProviderFactory?.Build();
    }

} // End Of Class

public static class InnerLicenseServerEndpointCredentialsProviderFactoryExtensions
{
    public static CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider(this InnerLicenseServerEndpointCredentialsProviderFactory parentFactory, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null)
    {
        parentFactory.SecretsManagerCredentialsProviderFactory = new InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SecretsManagerCredentialsProviderFactory);
    }

    public static CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1>(this CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1>(this CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2>(this CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2>(this CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2>(this CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2, T3, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3>(this CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2, T3, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory, T3, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory, T3> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2, T3, T4, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<InnerLicenseServerEndpointCredentialsProviderFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2, T3, T4, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, InnerLicenseServerEndpointCredentialsProviderFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory, T3, T4, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerLicenseServerEndpointCredentialsProviderFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory, T4, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerLicenseServerEndpointCredentialsProviderFactory, T4> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointCredentialsProviderFactory, InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory> WithSecretsManagerCredentialsProvider<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerLicenseServerEndpointCredentialsProviderFactory> combinedResult, Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSecretsManagerCredentialsProvider(combinedResult.T5, subFactoryAction).T2);
}
