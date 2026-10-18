// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Translate;

public class InnerParallelDataEncryptionKeyFactory(Action<Humidifier.Translate.ParallelDataTypes.EncryptionKey> factoryAction = null) : SubResourceFactory<Humidifier.Translate.ParallelDataTypes.EncryptionKey>
{

    protected override Humidifier.Translate.ParallelDataTypes.EncryptionKey Create()
    {
        var encryptionKeyResult = CreateEncryptionKey();
        factoryAction?.Invoke(encryptionKeyResult);

        return encryptionKeyResult;
    }

    private Humidifier.Translate.ParallelDataTypes.EncryptionKey CreateEncryptionKey()
    {
        var encryptionKeyResult = new Humidifier.Translate.ParallelDataTypes.EncryptionKey();

        return encryptionKeyResult;
    }

} // End Of Class

public static class InnerParallelDataEncryptionKeyFactoryExtensions
{
}
