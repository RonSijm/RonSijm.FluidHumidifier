// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerServiceMonitoringConfigurationFactory(Action<Humidifier.ECS.ServiceTypes.MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.ServiceTypes.MonitoringConfiguration>
{

    protected override Humidifier.ECS.ServiceTypes.MonitoringConfiguration Create()
    {
        var monitoringConfigurationResult = CreateMonitoringConfiguration();
        factoryAction?.Invoke(monitoringConfigurationResult);

        return monitoringConfigurationResult;
    }

    private Humidifier.ECS.ServiceTypes.MonitoringConfiguration CreateMonitoringConfiguration()
    {
        var monitoringConfigurationResult = new Humidifier.ECS.ServiceTypes.MonitoringConfiguration();

        return monitoringConfigurationResult;
    }

} // End Of Class

public static class InnerServiceMonitoringConfigurationFactoryExtensions
{
}
