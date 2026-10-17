// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class InnerMonitorMonitorLocalResourceFactory(Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource>
{

    protected override Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource Create()
    {
        var monitorLocalResourceResult = CreateMonitorLocalResource();
        factoryAction?.Invoke(monitorLocalResourceResult);

        return monitorLocalResourceResult;
    }

    private Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource CreateMonitorLocalResource()
    {
        var monitorLocalResourceResult = new Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource();

        return monitorLocalResourceResult;
    }

} // End Of Class

public static class InnerMonitorMonitorLocalResourceFactoryExtensions
{
}
