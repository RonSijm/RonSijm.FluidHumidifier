// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaInsightsPipelineConfigurationS3RecordingSinkConfigurationFactory(Action<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration>
{

    protected override Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration Create()
    {
        var s3RecordingSinkConfigurationResult = CreateS3RecordingSinkConfiguration();
        factoryAction?.Invoke(s3RecordingSinkConfigurationResult);

        return s3RecordingSinkConfigurationResult;
    }

    private Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration CreateS3RecordingSinkConfiguration()
    {
        var s3RecordingSinkConfigurationResult = new Humidifier.Chime.MediaInsightsPipelineConfigurationTypes.S3RecordingSinkConfiguration();

        return s3RecordingSinkConfigurationResult;
    }

} // End Of Class

public static class InnerMediaInsightsPipelineConfigurationS3RecordingSinkConfigurationFactoryExtensions
{
}
