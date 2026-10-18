// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerTranscriptionJobSubtitlesFactory(Action<Humidifier.Transcribe.TranscriptionJobTypes.Subtitles> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.TranscriptionJobTypes.Subtitles>
{

    protected override Humidifier.Transcribe.TranscriptionJobTypes.Subtitles Create()
    {
        var subtitlesResult = CreateSubtitles();
        factoryAction?.Invoke(subtitlesResult);

        return subtitlesResult;
    }

    private Humidifier.Transcribe.TranscriptionJobTypes.Subtitles CreateSubtitles()
    {
        var subtitlesResult = new Humidifier.Transcribe.TranscriptionJobTypes.Subtitles();

        return subtitlesResult;
    }

} // End Of Class

public static class InnerTranscriptionJobSubtitlesFactoryExtensions
{
}
