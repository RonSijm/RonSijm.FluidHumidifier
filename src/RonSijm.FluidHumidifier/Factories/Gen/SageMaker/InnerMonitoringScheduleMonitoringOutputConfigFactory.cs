// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleMonitoringOutputConfigFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig Create()
    {
        var monitoringOutputConfigResult = CreateMonitoringOutputConfig();
        factoryAction?.Invoke(monitoringOutputConfigResult);

        return monitoringOutputConfigResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig CreateMonitoringOutputConfig()
    {
        var monitoringOutputConfigResult = new Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringOutputConfig();

        return monitoringOutputConfigResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleMonitoringOutputConfigFactoryExtensions
{
}
