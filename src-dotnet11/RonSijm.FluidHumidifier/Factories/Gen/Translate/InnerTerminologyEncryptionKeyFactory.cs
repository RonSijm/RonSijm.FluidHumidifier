// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerTerminologyEncryptionKeyFactory(Action<Humidifier.Translate.TerminologyTypes.EncryptionKey> factoryAction = null) : SubResourceFactory<Humidifier.Translate.TerminologyTypes.EncryptionKey>
{

    protected override Humidifier.Translate.TerminologyTypes.EncryptionKey Create()
    {
        var encryptionKeyResult = CreateEncryptionKey();
        factoryAction?.Invoke(encryptionKeyResult);

        return encryptionKeyResult;
    }

    private Humidifier.Translate.TerminologyTypes.EncryptionKey CreateEncryptionKey()
    {
        var encryptionKeyResult = new Humidifier.Translate.TerminologyTypes.EncryptionKey();

        return encryptionKeyResult;
    }

} // End Of Class

public static class InnerTerminologyEncryptionKeyFactoryExtensions
{
}
