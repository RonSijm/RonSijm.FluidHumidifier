// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory(Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources>
{

    internal InnerModelExplainabilityJobDefinitionClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources Create()
    {
        var monitoringResourcesResult = CreateMonitoringResources();
        factoryAction?.Invoke(monitoringResourcesResult);

        return monitoringResourcesResult;
    }

    private Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources CreateMonitoringResources()
    {
        var monitoringResourcesResult = new Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources();

        return monitoringResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.MonitoringResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelExplainabilityJobDefinitionMonitoringResourcesFactoryExtensions
{
    public static CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig(this InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory parentFactory, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerModelExplainabilityJobDefinitionClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2, T3, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T3, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2, T3, T4, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T3, T4, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T4, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory, InnerModelExplainabilityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelExplainabilityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelExplainabilityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction));
}
