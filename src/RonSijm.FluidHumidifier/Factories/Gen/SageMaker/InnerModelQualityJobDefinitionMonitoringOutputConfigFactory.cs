// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionMonitoringOutputConfigFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig>
{

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig Create()
    {
        var monitoringOutputConfigResult = CreateMonitoringOutputConfig();
        factoryAction?.Invoke(monitoringOutputConfigResult);

        return monitoringOutputConfigResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig CreateMonitoringOutputConfig()
    {
        var monitoringOutputConfigResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringOutputConfig();

        return monitoringOutputConfigResult;
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionMonitoringOutputConfigFactoryExtensions
{
}
