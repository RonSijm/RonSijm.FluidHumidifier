// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateParametricCloudWatchMonitoringConfigurationFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration>
{

    protected override Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration Create()
    {
        var parametricCloudWatchMonitoringConfigurationResult = CreateParametricCloudWatchMonitoringConfiguration();
        factoryAction?.Invoke(parametricCloudWatchMonitoringConfigurationResult);

        return parametricCloudWatchMonitoringConfigurationResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration CreateParametricCloudWatchMonitoringConfiguration()
    {
        var parametricCloudWatchMonitoringConfigurationResult = new Humidifier.EMRContainers.JobTemplateTypes.ParametricCloudWatchMonitoringConfiguration();

        return parametricCloudWatchMonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerJobTemplateParametricCloudWatchMonitoringConfigurationFactoryExtensions
{
}
