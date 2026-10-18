// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerSpotInstancesRequestMonitoringEnabledFactory(Action<Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled> factoryAction = null) : SubResourceFactory<Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled>
{

    protected override Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled Create()
    {
        var monitoringEnabledResult = CreateMonitoringEnabled();
        factoryAction?.Invoke(monitoringEnabledResult);

        return monitoringEnabledResult;
    }

    private Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled CreateMonitoringEnabled()
    {
        var monitoringEnabledResult = new Humidifier.EC2.SpotInstancesRequestTypes.MonitoringEnabled();

        return monitoringEnabledResult;
    }

} // End Of Class

public static class InnerSpotInstancesRequestMonitoringEnabledFactoryExtensions
{
}
