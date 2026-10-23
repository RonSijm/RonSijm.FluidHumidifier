// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerCompositeAlarmAlarmTagsPropagationFactory(Action<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation>
{

    protected override Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation Create()
    {
        var alarmTagsPropagationResult = CreateAlarmTagsPropagation();
        factoryAction?.Invoke(alarmTagsPropagationResult);

        return alarmTagsPropagationResult;
    }

    private Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation CreateAlarmTagsPropagation()
    {
        var alarmTagsPropagationResult = new Humidifier.CloudWatch.CompositeAlarmTypes.AlarmTagsPropagation();

        return alarmTagsPropagationResult;
    }

} // End Of Class

public static class InnerCompositeAlarmAlarmTagsPropagationFactoryExtensions
{
}
