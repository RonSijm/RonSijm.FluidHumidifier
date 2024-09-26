// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class AlarmFactory(string resourceName = null, Action<Humidifier.Lightsail.Alarm> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.Alarm>(resourceName)
{

    protected override Humidifier.Lightsail.Alarm Create()
    {
        var alarmResult = CreateAlarm();
        factoryAction?.Invoke(alarmResult);

        return alarmResult;
    }

    private Humidifier.Lightsail.Alarm CreateAlarm()
    {
        var alarmResult = new Humidifier.Lightsail.Alarm
        {
            GivenName = InputResourceName,
        };

        return alarmResult;
    }

} // End Of Class

public static class AlarmFactoryExtensions
{
}
