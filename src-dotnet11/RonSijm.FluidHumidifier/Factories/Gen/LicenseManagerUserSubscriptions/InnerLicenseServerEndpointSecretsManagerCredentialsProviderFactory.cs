// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManagerUserSubscriptions;

public class InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactory(Action<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider>
{

    protected override Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider Create()
    {
        var secretsManagerCredentialsProviderResult = CreateSecretsManagerCredentialsProvider();
        factoryAction?.Invoke(secretsManagerCredentialsProviderResult);

        return secretsManagerCredentialsProviderResult;
    }

    private Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider CreateSecretsManagerCredentialsProvider()
    {
        var secretsManagerCredentialsProviderResult = new Humidifier.LicenseManagerUserSubscriptions.LicenseServerEndpointTypes.SecretsManagerCredentialsProvider();

        return secretsManagerCredentialsProviderResult;
    }

} // End Of Class

public static class InnerLicenseServerEndpointSecretsManagerCredentialsProviderFactoryExtensions
{
}
