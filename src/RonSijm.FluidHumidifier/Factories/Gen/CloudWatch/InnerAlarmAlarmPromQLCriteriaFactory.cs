// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerAlarmAlarmPromQLCriteriaFactory(Action<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria>
{

    protected override Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria Create()
    {
        var alarmPromQLCriteriaResult = CreateAlarmPromQLCriteria();
        factoryAction?.Invoke(alarmPromQLCriteriaResult);

        return alarmPromQLCriteriaResult;
    }

    private Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria CreateAlarmPromQLCriteria()
    {
        var alarmPromQLCriteriaResult = new Humidifier.CloudWatch.AlarmTypes.AlarmPromQLCriteria();

        return alarmPromQLCriteriaResult;
    }

} // End Of Class

public static class InnerAlarmAlarmPromQLCriteriaFactoryExtensions
{
}
