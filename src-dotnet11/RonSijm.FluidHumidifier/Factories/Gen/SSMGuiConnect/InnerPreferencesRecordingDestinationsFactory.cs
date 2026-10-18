// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMGuiConnect;

public class InnerPreferencesRecordingDestinationsFactory(Action<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations> factoryAction = null) : SubResourceFactory<Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations>
{

    protected override Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations Create()
    {
        var recordingDestinationsResult = CreateRecordingDestinations();
        factoryAction?.Invoke(recordingDestinationsResult);

        return recordingDestinationsResult;
    }

    private Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations CreateRecordingDestinations()
    {
        var recordingDestinationsResult = new Humidifier.SSMGuiConnect.PreferencesTypes.RecordingDestinations();

        return recordingDestinationsResult;
    }

} // End Of Class

public static class InnerPreferencesRecordingDestinationsFactoryExtensions
{
}
