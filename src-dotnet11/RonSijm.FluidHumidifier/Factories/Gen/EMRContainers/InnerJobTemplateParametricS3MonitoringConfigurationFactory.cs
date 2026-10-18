// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerJobTemplateParametricS3MonitoringConfigurationFactory(Action<Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration>
{

    protected override Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration Create()
    {
        var parametricS3MonitoringConfigurationResult = CreateParametricS3MonitoringConfiguration();
        factoryAction?.Invoke(parametricS3MonitoringConfigurationResult);

        return parametricS3MonitoringConfigurationResult;
    }

    private Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration CreateParametricS3MonitoringConfiguration()
    {
        var parametricS3MonitoringConfigurationResult = new Humidifier.EMRContainers.JobTemplateTypes.ParametricS3MonitoringConfiguration();

        return parametricS3MonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerJobTemplateParametricS3MonitoringConfigurationFactoryExtensions
{
}
