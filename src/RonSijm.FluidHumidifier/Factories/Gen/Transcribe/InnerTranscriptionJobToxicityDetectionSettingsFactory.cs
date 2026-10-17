// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerTranscriptionJobToxicityDetectionSettingsFactory(Action<Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings>
{

    protected override Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings Create()
    {
        var toxicityDetectionSettingsResult = CreateToxicityDetectionSettings();
        factoryAction?.Invoke(toxicityDetectionSettingsResult);

        return toxicityDetectionSettingsResult;
    }

    private Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings CreateToxicityDetectionSettings()
    {
        var toxicityDetectionSettingsResult = new Humidifier.Transcribe.TranscriptionJobTypes.ToxicityDetectionSettings();

        return toxicityDetectionSettingsResult;
    }

} // End Of Class

public static class InnerTranscriptionJobToxicityDetectionSettingsFactoryExtensions
{
}
