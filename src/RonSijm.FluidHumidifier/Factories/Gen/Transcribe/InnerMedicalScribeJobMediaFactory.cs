// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerMedicalScribeJobMediaFactory(Action<Humidifier.Transcribe.MedicalScribeJobTypes.Media> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.MedicalScribeJobTypes.Media>
{

    protected override Humidifier.Transcribe.MedicalScribeJobTypes.Media Create()
    {
        var mediaResult = CreateMedia();
        factoryAction?.Invoke(mediaResult);

        return mediaResult;
    }

    private Humidifier.Transcribe.MedicalScribeJobTypes.Media CreateMedia()
    {
        var mediaResult = new Humidifier.Transcribe.MedicalScribeJobTypes.Media();

        return mediaResult;
    }

} // End Of Class

public static class InnerMedicalScribeJobMediaFactoryExtensions
{
}
