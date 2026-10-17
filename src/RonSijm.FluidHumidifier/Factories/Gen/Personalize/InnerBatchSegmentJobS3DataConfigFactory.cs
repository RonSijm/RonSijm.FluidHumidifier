// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Personalize;

public class InnerBatchSegmentJobS3DataConfigFactory(Action<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig> factoryAction = null) : SubResourceFactory<Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig>
{

    protected override Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig Create()
    {
        var s3DataConfigResult = CreateS3DataConfig();
        factoryAction?.Invoke(s3DataConfigResult);

        return s3DataConfigResult;
    }

    private Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig CreateS3DataConfig()
    {
        var s3DataConfigResult = new Humidifier.Personalize.BatchSegmentJobTypes.S3DataConfig();

        return s3DataConfigResult;
    }

} // End Of Class

public static class InnerBatchSegmentJobS3DataConfigFactoryExtensions
{
}
