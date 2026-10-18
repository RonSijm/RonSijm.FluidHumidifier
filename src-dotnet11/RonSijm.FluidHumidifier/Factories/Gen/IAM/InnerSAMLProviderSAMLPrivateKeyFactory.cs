// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IAM;

public class InnerSAMLProviderSAMLPrivateKeyFactory(Action<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey> factoryAction = null) : SubResourceFactory<Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey>
{

    protected override Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey Create()
    {
        var sAMLPrivateKeyResult = CreateSAMLPrivateKey();
        factoryAction?.Invoke(sAMLPrivateKeyResult);

        return sAMLPrivateKeyResult;
    }

    private Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey CreateSAMLPrivateKey()
    {
        var sAMLPrivateKeyResult = new Humidifier.IAM.SAMLProviderTypes.SAMLPrivateKey();

        return sAMLPrivateKeyResult;
    }

} // End Of Class

public static class InnerSAMLProviderSAMLPrivateKeyFactoryExtensions
{
}
