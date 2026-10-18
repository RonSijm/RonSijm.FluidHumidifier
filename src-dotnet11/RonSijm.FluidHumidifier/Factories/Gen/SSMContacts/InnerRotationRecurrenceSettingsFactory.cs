// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSMContacts;

public class InnerRotationRecurrenceSettingsFactory(Action<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings> factoryAction = null) : SubResourceFactory<Humidifier.SSMContacts.RotationTypes.RecurrenceSettings>
{

    protected override Humidifier.SSMContacts.RotationTypes.RecurrenceSettings Create()
    {
        var recurrenceSettingsResult = CreateRecurrenceSettings();
        factoryAction?.Invoke(recurrenceSettingsResult);

        return recurrenceSettingsResult;
    }

    private Humidifier.SSMContacts.RotationTypes.RecurrenceSettings CreateRecurrenceSettings()
    {
        var recurrenceSettingsResult = new Humidifier.SSMContacts.RotationTypes.RecurrenceSettings();

        return recurrenceSettingsResult;
    }

} // End Of Class

public static class InnerRotationRecurrenceSettingsFactoryExtensions
{
}
