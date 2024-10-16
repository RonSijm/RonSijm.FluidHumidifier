// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionMonitoringOutputConfigFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig>
{

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig Create()
    {
        var monitoringOutputConfigResult = CreateMonitoringOutputConfig();
        factoryAction?.Invoke(monitoringOutputConfigResult);

        return monitoringOutputConfigResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig CreateMonitoringOutputConfig()
    {
        var monitoringOutputConfigResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringOutputConfig();

        return monitoringOutputConfigResult;
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionMonitoringOutputConfigFactoryExtensions
{
}
