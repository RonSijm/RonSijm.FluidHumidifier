// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobProcessingResourcesFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources>
{

    internal InnerProcessingJobClusterConfigFactory ClusterConfigFactory { get; set; }

    protected override Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources Create()
    {
        var processingResourcesResult = CreateProcessingResources();
        factoryAction?.Invoke(processingResourcesResult);

        return processingResourcesResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources CreateProcessingResources()
    {
        var processingResourcesResult = new Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources();

        return processingResourcesResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ProcessingJobTypes.ProcessingResources result)
    {
        base.CreateChildren(result);

        result.ClusterConfig ??= ClusterConfigFactory?.Build();
    }

} // End Of Class

public static class InnerProcessingJobProcessingResourcesFactoryExtensions
{
    public static CombinedResult<InnerProcessingJobProcessingResourcesFactory, InnerProcessingJobClusterConfigFactory> WithClusterConfig(this InnerProcessingJobProcessingResourcesFactory parentFactory, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null)
    {
        parentFactory.ClusterConfigFactory = new InnerProcessingJobClusterConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ClusterConfigFactory);
    }

    public static CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1>(this CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2>(this CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2, T3, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2, T3, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory, T3, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory, T3> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingResourcesFactory, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2, T3, T4, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<InnerProcessingJobProcessingResourcesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2, T3, T4, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerProcessingJobProcessingResourcesFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory, T3, T4, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerProcessingJobProcessingResourcesFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerProcessingJobProcessingResourcesFactory, T4, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerProcessingJobProcessingResourcesFactory, T4> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingResourcesFactory, InnerProcessingJobClusterConfigFactory> WithClusterConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerProcessingJobProcessingResourcesFactory> combinedResult, Action<Humidifier.SageMaker.ProcessingJobTypes.ClusterConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithClusterConfig(combinedResult.T5, subFactoryAction).T2);
}
