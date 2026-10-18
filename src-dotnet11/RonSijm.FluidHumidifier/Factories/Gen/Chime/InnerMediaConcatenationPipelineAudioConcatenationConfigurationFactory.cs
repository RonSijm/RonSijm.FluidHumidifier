// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineAudioConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration Create()
    {
        var audioConcatenationConfigurationResult = CreateAudioConcatenationConfiguration();
        factoryAction?.Invoke(audioConcatenationConfigurationResult);

        return audioConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration CreateAudioConcatenationConfiguration()
    {
        var audioConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.AudioConcatenationConfiguration();

        return audioConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineAudioConcatenationConfigurationFactoryExtensions
{
}
