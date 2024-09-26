// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerFeatureGroupS3StorageConfigFactory(Action<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig>
{

    protected override Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig Create()
    {
        var s3StorageConfigResult = CreateS3StorageConfig();
        factoryAction?.Invoke(s3StorageConfigResult);

        return s3StorageConfigResult;
    }

    private Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig CreateS3StorageConfig()
    {
        var s3StorageConfigResult = new Humidifier.SageMaker.FeatureGroupTypes.S3StorageConfig();

        return s3StorageConfigResult;
    }

} // End Of Class

public static class InnerFeatureGroupS3StorageConfigFactoryExtensions
{
}
