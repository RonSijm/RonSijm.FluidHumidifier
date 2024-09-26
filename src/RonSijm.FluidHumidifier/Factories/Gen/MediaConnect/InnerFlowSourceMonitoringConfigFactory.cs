// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourceMonitoringConfigFactory(Action<Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig>
{

    protected override Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig Create()
    {
        var sourceMonitoringConfigResult = CreateSourceMonitoringConfig();
        factoryAction?.Invoke(sourceMonitoringConfigResult);

        return sourceMonitoringConfigResult;
    }

    private Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig CreateSourceMonitoringConfig()
    {
        var sourceMonitoringConfigResult = new Humidifier.MediaConnect.FlowTypes.SourceMonitoringConfig();

        return sourceMonitoringConfigResult;
    }

} // End Of Class

public static class InnerFlowSourceMonitoringConfigFactoryExtensions
{
}
