// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class InnerMonitorMonitorRemoteResourceFactory(Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource>
{

    protected override Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource Create()
    {
        var monitorRemoteResourceResult = CreateMonitorRemoteResource();
        factoryAction?.Invoke(monitorRemoteResourceResult);

        return monitorRemoteResourceResult;
    }

    private Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource CreateMonitorRemoteResource()
    {
        var monitorRemoteResourceResult = new Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource();

        return monitorRemoteResourceResult;
    }

} // End Of Class

public static class InnerMonitorMonitorRemoteResourceFactoryExtensions
{
}
