// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerEndpointCloudWatchMonitoringConfigurationFactory(Action<Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration>
{

    protected override Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration Create()
    {
        var cloudWatchMonitoringConfigurationResult = CreateCloudWatchMonitoringConfiguration();
        factoryAction?.Invoke(cloudWatchMonitoringConfigurationResult);

        return cloudWatchMonitoringConfigurationResult;
    }

    private Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration CreateCloudWatchMonitoringConfiguration()
    {
        var cloudWatchMonitoringConfigurationResult = new Humidifier.EMRContainers.EndpointTypes.CloudWatchMonitoringConfiguration();

        return cloudWatchMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerEndpointCloudWatchMonitoringConfigurationFactoryExtensions
{
}
