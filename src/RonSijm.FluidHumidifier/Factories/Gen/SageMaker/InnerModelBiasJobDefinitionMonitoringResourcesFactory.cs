// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelBiasJobDefinitionMonitoringResourcesFactory(Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources>
{

    internal InnerModelBiasJobDefinitionClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources Create()
    {
        var monitoringResourcesResult = CreateMonitoringResources();
        factoryAction?.Invoke(monitoringResourcesResult);

        return monitoringResourcesResult;
    }

    private Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources CreateMonitoringResources()
    {
        var monitoringResourcesResult = new Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources();

        return monitoringResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelBiasJobDefinitionTypes.MonitoringResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerModelBiasJobDefinitionMonitoringResourcesFactoryExtensions
{
    public static CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig(this InnerModelBiasJobDefinitionMonitoringResourcesFactory parentFactory, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerModelBiasJobDefinitionClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2, T3, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2, T3, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T3, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionMonitoringResourcesFactory, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerModelBiasJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2, T3, T4, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T3, T4, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T4, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelBiasJobDefinitionMonitoringResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionMonitoringResourcesFactory, InnerModelBiasJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelBiasJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ModelBiasJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction));
}
