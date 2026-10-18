// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchInferenceJobS3DataConfigFactory(Action<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig>
{

    protected override Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig Create()
    {
        var s3DataConfigResult = CreateS3DataConfig();
        factoryAction?.Invoke(s3DataConfigResult);

        return s3DataConfigResult;
    }

    private Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig CreateS3DataConfig()
    {
        var s3DataConfigResult = new Humidifier.Personalize.BatchInferenceJobTypes.S3DataConfig();

        return s3DataConfigResult;
    }

} // End Of Class

public static class InnerBatchInferenceJobS3DataConfigFactoryExtensions
{
}
