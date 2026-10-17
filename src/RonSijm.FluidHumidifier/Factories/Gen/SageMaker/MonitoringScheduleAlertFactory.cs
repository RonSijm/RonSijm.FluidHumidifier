// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class MonitoringScheduleAlertFactory(string resourceName = null, Action<Humidifier.SageMaker.MonitoringScheduleAlert> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.MonitoringScheduleAlert>(resourceName)
{

    protected override Humidifier.SageMaker.MonitoringScheduleAlert Create()
    {
        var monitoringScheduleAlertResult = CreateMonitoringScheduleAlert();
        factoryAction?.Invoke(monitoringScheduleAlertResult);

        return monitoringScheduleAlertResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleAlert CreateMonitoringScheduleAlert()
    {
        var monitoringScheduleAlertResult = new Humidifier.SageMaker.MonitoringScheduleAlert
        {
            GivenName = InputResourceName,
        };

        return monitoringScheduleAlertResult;
    }

} // End Of Class

public static class MonitoringScheduleAlertFactoryExtensions
{
}
