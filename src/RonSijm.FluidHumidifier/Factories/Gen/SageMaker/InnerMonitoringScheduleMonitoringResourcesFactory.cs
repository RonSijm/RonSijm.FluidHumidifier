// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerMonitoringScheduleMonitoringResourcesFactory(Action<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources>
{

    internal InnerMonitoringScheduleClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources Create()
    {
        var monitoringResourcesResult = CreateMonitoringResources();
        factoryAction?.Invoke(monitoringResourcesResult);

        return monitoringResourcesResult;
    }

    private Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources CreateMonitoringResources()
    {
        var monitoringResourcesResult = new Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources();

        return monitoringResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.MonitoringScheduleTypes.MonitoringResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerMonitoringScheduleMonitoringResourcesFactoryExtensions
{
    public static CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig(this InnerMonitoringScheduleMonitoringResourcesFactory parentFactory, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerMonitoringScheduleClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2, T3, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2, T3, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory, T3, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringScheduleMonitoringResourcesFactory, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMonitoringScheduleMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2, T3, T4, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerMonitoringScheduleMonitoringResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2, T3, T4, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerMonitoringScheduleMonitoringResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory, T3, T4, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMonitoringScheduleMonitoringResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerMonitoringScheduleMonitoringResourcesFactory, T4, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMonitoringScheduleMonitoringResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerMonitoringScheduleMonitoringResourcesFactory, InnerMonitoringScheduleClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMonitoringScheduleMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.MonitoringScheduleTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction));
}
