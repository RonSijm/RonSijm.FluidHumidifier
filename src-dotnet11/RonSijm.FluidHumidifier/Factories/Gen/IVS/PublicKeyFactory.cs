// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class PublicKeyFactory(string resourceName = null, Action<Humidifier.IVS.PublicKey> factoryAction = null) : ResourceFactory<Humidifier.IVS.PublicKey>(resourceName)
{

    protected override Humidifier.IVS.PublicKey Create()
    {
        var publicKeyResult = CreatePublicKey();
        factoryAction?.Invoke(publicKeyResult);

        return publicKeyResult;
    }

    private Humidifier.IVS.PublicKey CreatePublicKey()
    {
        var publicKeyResult = new Humidifier.IVS.PublicKey
        {
            GivenName = InputResourceName,
        };

        return publicKeyResult;
    }

} // End Of Class

public static class PublicKeyFactoryExtensions
{
}
