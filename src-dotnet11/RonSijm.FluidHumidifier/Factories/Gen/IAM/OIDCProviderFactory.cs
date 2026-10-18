// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class OIDCProviderFactory(string resourceName = null, Action<Humidifier.IAM.OIDCProvider> factoryAction = null) : ResourceFactory<Humidifier.IAM.OIDCProvider>(resourceName)
{

    protected override Humidifier.IAM.OIDCProvider Create()
    {
        var oIDCProviderResult = CreateOIDCProvider();
        factoryAction?.Invoke(oIDCProviderResult);

        return oIDCProviderResult;
    }

    private Humidifier.IAM.OIDCProvider CreateOIDCProvider()
    {
        var oIDCProviderResult = new Humidifier.IAM.OIDCProvider
        {
            GivenName = InputResourceName,
        };

        return oIDCProviderResult;
    }

} // End Of Class

public static class OIDCProviderFactoryExtensions
{
}
