// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmAlarmTagsPropagationFactory(Action<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation>
{

    protected override Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation Create()
    {
        var alarmTagsPropagationResult = CreateAlarmTagsPropagation();
        factoryAction?.Invoke(alarmTagsPropagationResult);

        return alarmTagsPropagationResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation CreateAlarmTagsPropagation()
    {
        var alarmTagsPropagationResult = new Humidifier.CloudWatch.AlarmTypes.AlarmTagsPropagation();

        return alarmTagsPropagationResult;
    }

} // End Of Class

public static class InnerAlarmAlarmTagsPropagationFactoryExtensions
{
}
