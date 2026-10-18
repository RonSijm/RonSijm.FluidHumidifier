// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.VerifiedPermissions;

public class InnerIdentitySourceOpenIdConnectGroupConfigurationFactory(Action<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration>
{

    protected override Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration Create()
    {
        var openIdConnectGroupConfigurationResult = CreateOpenIdConnectGroupConfiguration();
        factoryAction?.Invoke(openIdConnectGroupConfigurationResult);

        return openIdConnectGroupConfigurationResult;
    }

    private Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration CreateOpenIdConnectGroupConfiguration()
    {
        var openIdConnectGroupConfigurationResult = new Humidifier.VerifiedPermissions.IdentitySourceTypes.OpenIdConnectGroupConfiguration();

        return openIdConnectGroupConfigurationResult;
    }

} // End Of Class

public static class InnerIdentitySourceOpenIdConnectGroupConfigurationFactoryExtensions
{
}
