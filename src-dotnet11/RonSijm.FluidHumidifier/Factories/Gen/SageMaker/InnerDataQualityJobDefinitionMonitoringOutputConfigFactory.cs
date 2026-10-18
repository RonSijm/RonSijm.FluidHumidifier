// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionMonitoringOutputConfigFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig>
{

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig Create()
    {
        var monitoringOutputConfigResult = CreateMonitoringOutputConfig();
        factoryAction?.Invoke(monitoringOutputConfigResult);

        return monitoringOutputConfigResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig CreateMonitoringOutputConfig()
    {
        var monitoringOutputConfigResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringOutputConfig();

        return monitoringOutputConfigResult;
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionMonitoringOutputConfigFactoryExtensions
{
}
