// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleMonitoringAppSpecificationFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification>
{

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification Create()
    {
        var monitoringAppSpecificationResult = CreateMonitoringAppSpecification();
        factoryAction?.Invoke(monitoringAppSpecificationResult);

        return monitoringAppSpecificationResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification CreateMonitoringAppSpecification()
    {
        var monitoringAppSpecificationResult = new Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringAppSpecification();

        return monitoringAppSpecificationResult;
    }

} // End Of Class

public static class InnerMonitoringScheduleMonitoringAppSpecificationFactoryExtensions
{
}
