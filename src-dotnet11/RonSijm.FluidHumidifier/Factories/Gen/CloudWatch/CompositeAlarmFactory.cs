// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class CompositeAlarmFactory(string resourceName = null, Action<Humidifier.CloudWatch.CompositeAlarm> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.CompositeAlarm>(resourceName)
{

    protected override Humidifier.CloudWatch.CompositeAlarm Create()
    {
        var compositeAlarmResult = CreateCompositeAlarm();
        factoryAction?.Invoke(compositeAlarmResult);

        return compositeAlarmResult;
    }

    private Humidifier.CloudWatch.CompositeAlarm CreateCompositeAlarm()
    {
        var compositeAlarmResult = new Humidifier.CloudWatch.CompositeAlarm
        {
            GivenName = InputResourceName,
        };

        return compositeAlarmResult;
    }

} // End Of Class

public static class CompositeAlarmFactoryExtensions
{
}
