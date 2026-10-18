// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GroundStation;

public class InnerConfigS3RecordingConfigFactory(Action<Humidifier.GroundStation.ConfigTypes.S3RecordingConfig> factoryAction = null) : SubResourceFactory<Humidifier.GroundStation.ConfigTypes.S3RecordingConfig>
{

    protected override Humidifier.GroundStation.ConfigTypes.S3RecordingConfig Create()
    {
        var s3RecordingConfigResult = CreateS3RecordingConfig();
        factoryAction?.Invoke(s3RecordingConfigResult);

        return s3RecordingConfigResult;
    }

    private Humidifier.GroundStation.ConfigTypes.S3RecordingConfig CreateS3RecordingConfig()
    {
        var s3RecordingConfigResult = new Humidifier.GroundStation.ConfigTypes.S3RecordingConfig();

        return s3RecordingConfigResult;
    }

} // End Of Class

public static class InnerConfigS3RecordingConfigFactoryExtensions
{
}
