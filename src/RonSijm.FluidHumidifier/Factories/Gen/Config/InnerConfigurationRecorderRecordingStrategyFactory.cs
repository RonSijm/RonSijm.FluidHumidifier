// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Config;

public class InnerConfigurationRecorderRecordingStrategyFactory(Action<Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy> factoryAction = null) : SubResourceFactory<Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy>
{

    protected override Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy Create()
    {
        var recordingStrategyResult = CreateRecordingStrategy();
        factoryAction?.Invoke(recordingStrategyResult);

        return recordingStrategyResult;
    }

    private Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy CreateRecordingStrategy()
    {
        var recordingStrategyResult = new Humidifier.Config.ConfigurationRecorderTypes.RecordingStrategy();

        return recordingStrategyResult;
    }

} // End Of Class

public static class InnerConfigurationRecorderRecordingStrategyFactoryExtensions
{
}
