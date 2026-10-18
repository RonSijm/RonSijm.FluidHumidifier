// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigurationRecorderRecordingModeFactory(Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigurationRecorderTypes.RecordingMode>
{

    protected override Humidifier.Config.ConfigurationRecorderTypes.RecordingMode Create()
    {
        var recordingModeResult = CreateRecordingMode();
        factoryAction?.Invoke(recordingModeResult);

        return recordingModeResult;
    }

    private Humidifier.Config.ConfigurationRecorderTypes.RecordingMode CreateRecordingMode()
    {
        var recordingModeResult = new Humidifier.Config.ConfigurationRecorderTypes.RecordingMode();

        return recordingModeResult;
    }

} // End Of Class

public static class InnerConfigurationRecorderRecordingModeFactoryExtensions
{
}
