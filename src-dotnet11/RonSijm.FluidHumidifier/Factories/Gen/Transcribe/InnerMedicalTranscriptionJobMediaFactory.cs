// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalTranscriptionJobMediaFactory(Action<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media>
{

    protected override Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media Create()
    {
        var mediaResult = CreateMedia();
        factoryAction?.Invoke(mediaResult);

        return mediaResult;
    }

    private Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media CreateMedia()
    {
        var mediaResult = new Humidifier.Transcribe.MedicalTranscriptionJobTypes.Media();

        return mediaResult;
    }

} // End Of Class

public static class InnerMedicalTranscriptionJobMediaFactoryExtensions
{
}
