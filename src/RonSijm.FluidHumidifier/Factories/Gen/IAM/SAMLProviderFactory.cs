// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class SAMLProviderFactory(string resourceName = null, Action<Humidifier.IAM.SAMLProvider> factoryAction = null) : ResourceFactory<Humidifier.IAM.SAMLProvider>(resourceName)
{

    protected override Humidifier.IAM.SAMLProvider Create()
    {
        var sAMLProviderResult = CreateSAMLProvider();
        factoryAction?.Invoke(sAMLProviderResult);

        return sAMLProviderResult;
    }

    private Humidifier.IAM.SAMLProvider CreateSAMLProvider()
    {
        var sAMLProviderResult = new Humidifier.IAM.SAMLProvider
        {
            GivenName = InputResourceName,
        };

        return sAMLProviderResult;
    }

} // End Of Class

public static class SAMLProviderFactoryExtensions
{
}
