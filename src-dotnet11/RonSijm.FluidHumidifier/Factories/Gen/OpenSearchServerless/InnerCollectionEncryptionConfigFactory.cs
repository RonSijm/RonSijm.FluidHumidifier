// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpenSearchServerless;

public class InnerCollectionEncryptionConfigFactory(Action<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig>
{

    protected override Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig Create()
    {
        var encryptionConfigResult = CreateEncryptionConfig();
        factoryAction?.Invoke(encryptionConfigResult);

        return encryptionConfigResult;
    }

    private Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig CreateEncryptionConfig()
    {
        var encryptionConfigResult = new Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig();

        return encryptionConfigResult;
    }

} // End Of Class

public static class InnerCollectionEncryptionConfigFactoryExtensions
{
}
