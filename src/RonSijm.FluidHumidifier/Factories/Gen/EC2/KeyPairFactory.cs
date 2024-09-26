// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class KeyPairFactory(string resourceName = null, Action<Humidifier.EC2.KeyPair> factoryAction = null) : ResourceFactory<Humidifier.EC2.KeyPair>(resourceName)
{

    protected override Humidifier.EC2.KeyPair Create()
    {
        var keyPairResult = CreateKeyPair();
        factoryAction?.Invoke(keyPairResult);

        return keyPairResult;
    }

    private Humidifier.EC2.KeyPair CreateKeyPair()
    {
        var keyPairResult = new Humidifier.EC2.KeyPair
        {
            GivenName = InputResourceName,
        };

        return keyPairResult;
    }

} // End Of Class

public static class KeyPairFactoryExtensions
{
}
