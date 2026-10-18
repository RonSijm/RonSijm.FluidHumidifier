// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerIdentitySourceOpenIdConnectAccessTokenConfigurationFactory(Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration>
{

    protected override Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration Create()
    {
        var openIdConnectAccessTokenConfigurationResult = CreateOpenIdConnectAccessTokenConfiguration();
        factoryAction?.Invoke(openIdConnectAccessTokenConfigurationResult);

        return openIdConnectAccessTokenConfigurationResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration CreateOpenIdConnectAccessTokenConfiguration()
    {
        var openIdConnectAccessTokenConfigurationResult = new Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectAccessTokenConfiguration();

        return openIdConnectAccessTokenConfigurationResult;
    }

} // End Of Class

public static class InnerIdentitySourceOpenIdConnectAccessTokenConfigurationFactoryExtensions
{
}
