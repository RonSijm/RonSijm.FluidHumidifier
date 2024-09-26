// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerStorageConfigurationS3StorageConfigurationFactory(Action<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration>
{

    protected override Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration Create()
    {
        var s3StorageConfigurationResult = CreateS3StorageConfiguration();
        factoryAction?.Invoke(s3StorageConfigurationResult);

        return s3StorageConfigurationResult;
    }

    private Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration CreateS3StorageConfiguration()
    {
        var s3StorageConfigurationResult = new Humidifier.IVS.StorageConfigurationTypes.S3StorageConfiguration();

        return s3StorageConfigurationResult;
    }

} // End Of Class

public static class InnerStorageConfigurationS3StorageConfigurationFactoryExtensions
{
}
