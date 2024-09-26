// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class KeySigningKeyFactory(string resourceName = null, Action<Humidifier.Route53.KeySigningKey> factoryAction = null) : ResourceFactory<Humidifier.Route53.KeySigningKey>(resourceName)
{

    protected override Humidifier.Route53.KeySigningKey Create()
    {
        var keySigningKeyResult = CreateKeySigningKey();
        factoryAction?.Invoke(keySigningKeyResult);

        return keySigningKeyResult;
    }

    private Humidifier.Route53.KeySigningKey CreateKeySigningKey()
    {
        var keySigningKeyResult = new Humidifier.Route53.KeySigningKey
        {
            GivenName = InputResourceName,
        };

        return keySigningKeyResult;
    }

} // End Of Class

public static class KeySigningKeyFactoryExtensions
{
}
