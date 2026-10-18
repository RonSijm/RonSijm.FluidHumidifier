// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerTelemetryPipelinesTelemetryPipelineConfigurationFactory(Action<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration>
{

    protected override Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration Create()
    {
        var telemetryPipelineConfigurationResult = CreateTelemetryPipelineConfiguration();
        factoryAction?.Invoke(telemetryPipelineConfigurationResult);

        return telemetryPipelineConfigurationResult;
    }

    private Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration CreateTelemetryPipelineConfiguration()
    {
        var telemetryPipelineConfigurationResult = new Humidifier.ObservabilityAdmin.TelemetryPipelinesTypes.TelemetryPipelineConfiguration();

        return telemetryPipelineConfigurationResult;
    }

} // End Of Class

public static class InnerTelemetryPipelinesTelemetryPipelineConfigurationFactoryExtensions
{
}
