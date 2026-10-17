// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaPipelineKinesisVideoStreamPoolStreamConfigurationFactory(Action<Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration>
{

    protected override Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration Create()
    {
        var streamConfigurationResult = CreateStreamConfiguration();
        factoryAction?.Invoke(streamConfigurationResult);

        return streamConfigurationResult;
    }

    private Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration CreateStreamConfiguration()
    {
        var streamConfigurationResult = new Humidifier.Chime.MediaPipelineKinesisVideoStreamPoolTypes.StreamConfiguration();

        return streamConfigurationResult;
    }

} // End Of Class

public static class InnerMediaPipelineKinesisVideoStreamPoolStreamConfigurationFactoryExtensions
{
}
