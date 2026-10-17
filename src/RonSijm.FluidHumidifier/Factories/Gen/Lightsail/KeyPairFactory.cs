// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class KeyPairFactory(string resourceName = null, Action<Humidifier.Lightsail.KeyPair> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.KeyPair>(resourceName)
{

    protected override Humidifier.Lightsail.KeyPair Create()
    {
        var keyPairResult = CreateKeyPair();
        factoryAction?.Invoke(keyPairResult);

        return keyPairResult;
    }

    private Humidifier.Lightsail.KeyPair CreateKeyPair()
    {
        var keyPairResult = new Humidifier.Lightsail.KeyPair
        {
            GivenName = InputResourceName,
        };

        return keyPairResult;
    }

} // End Of Class

public static class KeyPairFactoryExtensions
{
}
