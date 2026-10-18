// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerInstanceStorageConfigEncryptionConfigFactory(Action<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig> factoryAction = null) : SubResourceFactory<Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig>
{

    protected override Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig Create()
    {
        var encryptionConfigResult = CreateEncryptionConfig();
        factoryAction?.Invoke(encryptionConfigResult);

        return encryptionConfigResult;
    }

    private Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig CreateEncryptionConfig()
    {
        var encryptionConfigResult = new Humidifier.Connect.InstanceStorageConfigTypes.EncryptionConfig();

        return encryptionConfigResult;
    }

} // End Of Class

public static class InnerInstanceStorageConfigEncryptionConfigFactoryExtensions
{
}
