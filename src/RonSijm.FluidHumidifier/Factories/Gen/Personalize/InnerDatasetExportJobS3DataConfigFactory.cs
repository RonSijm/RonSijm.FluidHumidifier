// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerDatasetExportJobS3DataConfigFactory(Action<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig>
{

    protected override Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig Create()
    {
        var s3DataConfigResult = CreateS3DataConfig();
        factoryAction?.Invoke(s3DataConfigResult);

        return s3DataConfigResult;
    }

    private Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig CreateS3DataConfig()
    {
        var s3DataConfigResult = new Humidifier.Personalize.DatasetExportJobTypes.S3DataConfig();

        return s3DataConfigResult;
    }

} // End Of Class

public static class InnerDatasetExportJobS3DataConfigFactoryExtensions
{
}
