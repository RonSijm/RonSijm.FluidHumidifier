// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobRunCloudWatchMonitoringConfigurationFactory(Action<Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration>
{

    protected override Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration Create()
    {
        var cloudWatchMonitoringConfigurationResult = CreateCloudWatchMonitoringConfiguration();
        factoryAction?.Invoke(cloudWatchMonitoringConfigurationResult);

        return cloudWatchMonitoringConfigurationResult;
    }

    private Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration CreateCloudWatchMonitoringConfiguration()
    {
        var cloudWatchMonitoringConfigurationResult = new Humidifier.EMRContainers.JobRunTypes.CloudWatchMonitoringConfiguration();

        return cloudWatchMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerJobRunCloudWatchMonitoringConfigurationFactoryExtensions
{
}
