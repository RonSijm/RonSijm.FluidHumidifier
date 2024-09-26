// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelQualityJobDefinitionMonitoringResourcesFactory(Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources>
{

    internal InnerModelQualityJobDefinitionClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources Create()
    {
        var monitoringResourcesResult = CreateMonitoringResources();
        factoryAction?.Invoke(monitoringResourcesResult);

        return monitoringResourcesResult;
    }

    private Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources CreateMonitoringResources()
    {
        var monitoringResourcesResult = new Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources();

        return monitoringResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelQualityJobDefinitionTypes.MonitoringResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelQualityJobDefinitionMonitoringResourcesFactoryExtensions
{
    public static CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig(this InnerModelQualityJobDefinitionMonitoringResourcesFactory parentFactory, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerModelQualityJobDefinitionClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2, T3, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T3, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionMonitoringResourcesFactory, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2, T3, T4, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T3, T4, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T4, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelQualityJobDefinitionMonitoringResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionMonitoringResourcesFactory, InnerModelQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction));
}
