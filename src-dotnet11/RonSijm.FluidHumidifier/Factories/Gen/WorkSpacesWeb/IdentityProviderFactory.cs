// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class IdentityProviderFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.IdentityProvider> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.IdentityProvider>(resourceName)
{

    protected override Humidifier.WorkSpacesWeb.IdentityProvider Create()
    {
        var identityProviderResult = CreateIdentityProvider();
        factoryAction?.Invoke(identityProviderResult);

        return identityProviderResult;
    }

    private Humidifier.WorkSpacesWeb.IdentityProvider CreateIdentityProvider()
    {
        var identityProviderResult = new Humidifier.WorkSpacesWeb.IdentityProvider
        {
            GivenName = InputResourceName,
        };

        return identityProviderResult;
    }

} // End Of Class

public static class IdentityProviderFactoryExtensions
{
}
