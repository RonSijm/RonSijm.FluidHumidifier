// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerDataQualityJobDefinitionMonitoringResourcesFactory(Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources>
{

    internal InnerDataQualityJobDefinitionClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources Create()
    {
        var monitoringResourcesResult = CreateMonitoringResources();
        factoryAction?.Invoke(monitoringResourcesResult);

        return monitoringResourcesResult;
    }

    private Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources CreateMonitoringResources()
    {
        var monitoringResourcesResult = new Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources();

        return monitoringResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.DataQualityJobDefinitionTypes.MonitoringResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerDataQualityJobDefinitionMonitoringResourcesFactoryExtensions
{
    public static CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig(this InnerDataQualityJobDefinitionMonitoringResourcesFactory parentFactory, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerDataQualityJobDefinitionClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2, T3, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T3, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionMonitoringResourcesFactory, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerDataQualityJobDefinitionMonitoringResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2, T3, T4, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T3, T4, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T4, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerDataQualityJobDefinitionMonitoringResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionMonitoringResourcesFactory, InnerDataQualityJobDefinitionClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerDataQualityJobDefinitionMonitoringResourcesFactory> combinedResult, Action<Humidifier.SageMaker.DataQualityJobDefinitionTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction));
}
