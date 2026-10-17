// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaCapturePipelineAudioArtifactsConfigurationFactory(Action<Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration>
{

    protected override Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration Create()
    {
        var audioArtifactsConfigurationResult = CreateAudioArtifactsConfiguration();
        factoryAction?.Invoke(audioArtifactsConfigurationResult);

        return audioArtifactsConfigurationResult;
    }

    private Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration CreateAudioArtifactsConfiguration()
    {
        var audioArtifactsConfigurationResult = new Humidifier.Chime.MediaCapturePipelineTypes.AudioArtifactsConfiguration();

        return audioArtifactsConfigurationResult;
    }

} // End Of Class

public static class InnerMediaCapturePipelineAudioArtifactsConfigurationFactoryExtensions
{
}
