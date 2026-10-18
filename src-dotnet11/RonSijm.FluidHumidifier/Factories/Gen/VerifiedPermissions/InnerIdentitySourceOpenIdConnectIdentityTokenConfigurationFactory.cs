// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerIdentitySourceOpenIdConnectIdentityTokenConfigurationFactory(Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration>
{

    protected override Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration Create()
    {
        var openIdConnectIdentityTokenConfigurationResult = CreateOpenIdConnectIdentityTokenConfiguration();
        factoryAction?.Invoke(openIdConnectIdentityTokenConfigurationResult);

        return openIdConnectIdentityTokenConfigurationResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration CreateOpenIdConnectIdentityTokenConfiguration()
    {
        var openIdConnectIdentityTokenConfigurationResult = new Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectIdentityTokenConfiguration();

        return openIdConnectIdentityTokenConfigurationResult;
    }

} // End Of Class

public static class InnerIdentitySourceOpenIdConnectIdentityTokenConfigurationFactoryExtensions
{
}
