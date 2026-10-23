// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerLogAlarmAlarmTagsPropagationFactory(Action<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation>
{

    protected override Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation Create()
    {
        var alarmTagsPropagationResult = CreateAlarmTagsPropagation();
        factoryAction?.Invoke(alarmTagsPropagationResult);

        return alarmTagsPropagationResult;
    }

    private Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation CreateAlarmTagsPropagation()
    {
        var alarmTagsPropagationResult = new Humidifier.CloudWatch.LogAlarmTypes.AlarmTagsPropagation();

        return alarmTagsPropagationResult;
    }

} // End Of Class

public static class InnerLogAlarmAlarmTagsPropagationFactoryExtensions
{
}
