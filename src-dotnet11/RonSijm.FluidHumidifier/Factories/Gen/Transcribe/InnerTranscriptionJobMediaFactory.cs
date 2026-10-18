// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerTranscriptionJobMediaFactory(Action<Humidifier.Transcribe.TranscriptionJobTypes.Media> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.TranscriptionJobTypes.Media>
{

    protected override Humidifier.Transcribe.TranscriptionJobTypes.Media Create()
    {
        var mediaResult = CreateMedia();
        factoryAction?.Invoke(mediaResult);

        return mediaResult;
    }

    private Humidifier.Transcribe.TranscriptionJobTypes.Media CreateMedia()
    {
        var mediaResult = new Humidifier.Transcribe.TranscriptionJobTypes.Media();

        return mediaResult;
    }

} // End Of Class

public static class InnerTranscriptionJobMediaFactoryExtensions
{
}
