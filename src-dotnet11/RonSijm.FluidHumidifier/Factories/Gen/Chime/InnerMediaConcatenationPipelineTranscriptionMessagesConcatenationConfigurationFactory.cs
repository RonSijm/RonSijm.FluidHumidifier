// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineTranscriptionMessagesConcatenationConfigurationFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration>
{

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration Create()
    {
        var transcriptionMessagesConcatenationConfigurationResult = CreateTranscriptionMessagesConcatenationConfiguration();
        factoryAction?.Invoke(transcriptionMessagesConcatenationConfigurationResult);

        return transcriptionMessagesConcatenationConfigurationResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration CreateTranscriptionMessagesConcatenationConfiguration()
    {
        var transcriptionMessagesConcatenationConfigurationResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.TranscriptionMessagesConcatenationConfiguration();

        return transcriptionMessagesConcatenationConfigurationResult;
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineTranscriptionMessagesConcatenationConfigurationFactoryExtensions
{
}
