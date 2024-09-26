// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerIdentityProviderConfigOidcIdentityProviderConfigFactory(Action<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig>
{

    protected override Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig Create()
    {
        var oidcIdentityProviderConfigResult = CreateOidcIdentityProviderConfig();
        factoryAction?.Invoke(oidcIdentityProviderConfigResult);

        return oidcIdentityProviderConfigResult;
    }

    private Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig CreateOidcIdentityProviderConfig()
    {
        var oidcIdentityProviderConfigResult = new Humidifier.EKS.IdentityProviderConfigTypes.OidcIdentityProviderConfig();

        return oidcIdentityProviderConfigResult;
    }

} // End Of Class

public static class InnerIdentityProviderConfigOidcIdentityProviderConfigFactoryExtensions
{
}
