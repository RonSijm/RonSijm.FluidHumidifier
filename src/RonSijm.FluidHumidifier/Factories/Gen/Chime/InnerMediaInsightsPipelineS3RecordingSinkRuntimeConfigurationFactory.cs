// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineS3RecordingSinkRuntimeConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration Create()
    {
        var s3RecordingSinkRuntimeConfigurationResult = CreateS3RecordingSinkRuntimeConfiguration();
        factoryAction?.Invoke(s3RecordingSinkRuntimeConfigurationResult);

        return s3RecordingSinkRuntimeConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration CreateS3RecordingSinkRuntimeConfiguration()
    {
        var s3RecordingSinkRuntimeConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineTypes.S3RecordingSinkRuntimeConfiguration();

        return s3RecordingSinkRuntimeConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineS3RecordingSinkRuntimeConfigurationFactoryExtensions
{
}
