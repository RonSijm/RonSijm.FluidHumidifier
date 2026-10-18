// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Transcribe;

public class InnerTranscriptionJobSettingsFactory(Action<Humidifier.Transcribe.TranscriptionJobTypes.Settings> factoryAction = null) : SubResourceFactory<Humidifier.Transcribe.TranscriptionJobTypes.Settings>
{

    protected override Humidifier.Transcribe.TranscriptionJobTypes.Settings Create()
    {
        var settingsResult = CreateSettings();
        factoryAction?.Invoke(settingsResult);

        return settingsResult;
    }

    private Humidifier.Transcribe.TranscriptionJobTypes.Settings CreateSettings()
    {
        var settingsResult = new Humidifier.Transcribe.TranscriptionJobTypes.Settings();

        return settingsResult;
    }

} // End Of Class

public static class InnerTranscriptionJobSettingsFactoryExtensions
{
}
