// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHealthCheckAlarmIdentifierFactory(Action<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HealthCheckTypes.AlarmIdentifier>
{

    protected override Humidifier.Route53.HealthCheckTypes.AlarmIdentifier Create()
    {
        var alarmIdentifierResult = CreateAlarmIdentifier();
        factoryAction?.Invoke(alarmIdentifierResult);

        return alarmIdentifierResult;
    }

    private Humidifier.Route53.HealthCheckTypes.AlarmIdentifier CreateAlarmIdentifier()
    {
        var alarmIdentifierResult = new Humidifier.Route53.HealthCheckTypes.AlarmIdentifier();

        return alarmIdentifierResult;
    }

} // End Of Class

public static class InnerHealthCheckAlarmIdentifierFactoryExtensions
{
}
