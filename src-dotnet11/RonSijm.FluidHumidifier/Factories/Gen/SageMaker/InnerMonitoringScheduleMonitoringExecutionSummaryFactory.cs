// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleMonitoringExecutionSummaryFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary Create()
    {
        var monitoringExecutionSummaryResult = CreateMonitoringExecutionSummary();
        factoryAction?.Invoke(monitoringExecutionSummaryResult);

        return monitoringExecutionSummaryResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary CreateMonitoringExecutionSummary()
    {
        var monitoringExecutionSummaryResult = new Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringExecutionSummary();

        return monitoringExecutionSummaryResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleMonitoringExecutionSummaryFactoryExtensions
{
}
