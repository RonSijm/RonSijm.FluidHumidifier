// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionMonitoringOutputConfigFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringOutputConfig>
{

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringOutputConfig Create()
    {
        var monitoringOutputConfigResult = CreateMonitoringOutputConfig();
        factoryAction?.Invoke(monitoringOutputConfigResult);

        return monitoringOutputConfigResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringOutputConfig CreateMonitoringOutputConfig()
    {
        var monitoringOutputConfigResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringOutputConfig();

        return monitoringOutputConfigResult;
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionMonitoringOutputConfigFactoryExtensions
{
}
