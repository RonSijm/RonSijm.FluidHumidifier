// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFlowMonitor;

public class MonitorFactory(string resourceName = null, Action<Humidifier.NetworkFlowMonitor.Monitor> factoryAction = null) : ResourceFactory<Humidifier.NetworkFlowMonitor.Monitor>(resourceName)
{

    internal List<InnerMonitorMonitorLocalResourceFactory> LocalResourcesFactories { get; set; } = [];

    internal List<InnerMonitorMonitorRemoteResourceFactory> RemoteResourcesFactories { get; set; } = [];

    protected override Humidifier.NetworkFlowMonitor.Monitor Create()
    {
        var monitorResult = CreateMonitor();
        factoryAction?.Invoke(monitorResult);

        return monitorResult;
    }

    private Humidifier.NetworkFlowMonitor.Monitor CreateMonitor()
    {
        var monitorResult = new Humidifier.NetworkFlowMonitor.Monitor
        {
            GivenName = InputResourceName,
        };

        return monitorResult;
    }
    public override void CreateChildren(Humidifier.NetworkFlowMonitor.Monitor result)
    {
        base.CreateChildren(result);

        result.LocalResources = LocalResourcesFactories.Any() ? LocalResourcesFactories.Select(x => x.Build()).ToList() : null;
        result.RemoteResources = RemoteResourcesFactories.Any() ? RemoteResourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MonitorFactoryExtensions
{
    public static CombinedResult<MonitorFactory, InnerMonitorMonitorLocalResourceFactory> WithLocalResources(this MonitorFactory parentFactory, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null)
    {
        var factory = new InnerMonitorMonitorLocalResourceFactory(subFactoryAction);
        parentFactory.LocalResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MonitorFactory, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources(this MonitorFactory parentFactory, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null)
    {
        var factory = new InnerMonitorMonitorRemoteResourceFactory(subFactoryAction);
        parentFactory.RemoteResourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MonitorFactory, T1, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1>(this CombinedResult<MonitorFactory, T1> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocalResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1>(this CombinedResult<T1, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocalResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2>(this CombinedResult<MonitorFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2>(this CombinedResult<T1, MonitorFactory, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2>(this CombinedResult<T1, T2, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, T3, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3>(this CombinedResult<MonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, T3, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3>(this CombinedResult<T1, MonitorFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, T3, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3>(this CombinedResult<T1, T2, MonitorFactory, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MonitorFactory, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, T3, T4, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3, T4>(this CombinedResult<MonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, T3, T4, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3, T4>(this CombinedResult<T1, MonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, T3, T4, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitorFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MonitorFactory, T4, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitorFactory, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MonitorFactory, InnerMonitorMonitorLocalResourceFactory> WithLocalResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorLocalResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocalResources(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1>(this CombinedResult<MonitorFactory, T1> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithRemoteResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1>(this CombinedResult<T1, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithRemoteResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2>(this CombinedResult<MonitorFactory, T1, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2>(this CombinedResult<T1, MonitorFactory, T2> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2>(this CombinedResult<T1, T2, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, T3, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3>(this CombinedResult<MonitorFactory, T1, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, T3, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3>(this CombinedResult<T1, MonitorFactory, T2, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, T3, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3>(this CombinedResult<T1, T2, MonitorFactory, T3> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MonitorFactory, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3>(this CombinedResult<T1, T2, T3, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MonitorFactory, T1, T2, T3, T4, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3, T4>(this CombinedResult<MonitorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MonitorFactory, T2, T3, T4, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3, T4>(this CombinedResult<T1, MonitorFactory, T2, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MonitorFactory, T3, T4, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, MonitorFactory, T3, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MonitorFactory, T4, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MonitorFactory, T4> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MonitorFactory, InnerMonitorMonitorRemoteResourceFactory> WithRemoteResources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MonitorFactory> combinedResult, Action<Humidifier.NetworkFlowMonitor.MonitorTypes.MonitorRemoteResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRemoteResources(combinedResult.T5, subFactoryAction).T2);
}
