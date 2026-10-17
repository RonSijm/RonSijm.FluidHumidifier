// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppFabric;

public class InnerAppAuthorizationOauth2CredentialFactory(Action<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential> factoryAction = null) : SubResourceFactory<Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential>
{

    protected override Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential Create()
    {
        var oauth2CredentialResult = CreateOauth2Credential();
        factoryAction?.Invoke(oauth2CredentialResult);

        return oauth2CredentialResult;
    }

    private Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential CreateOauth2Credential()
    {
        var oauth2CredentialResult = new Humidifier.AppFabric.AppAuthorizationTypes.Oauth2Credential();

        return oauth2CredentialResult;
    }

} // End Of Class

public static class InnerAppAuthorizationOauth2CredentialFactoryExtensions
{
}
