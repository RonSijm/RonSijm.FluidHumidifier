// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterKubeSchedulerConfigFactory(Action<Humidifier.EKS.ClusterTypes.KubeSchedulerConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.KubeSchedulerConfig>
{

    internal InnerClusterNodeResourcesFitConfigFactory NodeResourcesFitFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.KubeSchedulerConfig Create()
    {
        var kubeSchedulerConfigResult = CreateKubeSchedulerConfig();
        factoryAction?.Invoke(kubeSchedulerConfigResult);

        return kubeSchedulerConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.KubeSchedulerConfig CreateKubeSchedulerConfig()
    {
        var kubeSchedulerConfigResult = new Humidifier.EKS.ClusterTypes.KubeSchedulerConfig();

        return kubeSchedulerConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.KubeSchedulerConfig result)
    {
        base.CreateChildren(result);

        result.NodeResourcesFit ??= NodeResourcesFitFactory?.Build();
    }

} // End Of Class

public static class InnerClusterKubeSchedulerConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterKubeSchedulerConfigFactory, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit(this InnerClusterKubeSchedulerConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null)
    {
        parentFactory.NodeResourcesFitFactory = new InnerClusterNodeResourcesFitConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NodeResourcesFitFactory);
    }

    public static CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1>(this CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1>(this CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2>(this CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2>(this CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2>(this CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2, T3, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3>(this CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2, T3, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3>(this CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory, T3, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterKubeSchedulerConfigFactory, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterKubeSchedulerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2, T3, T4, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3, T4>(this CombinedResult<InnerClusterKubeSchedulerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2, T3, T4, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterKubeSchedulerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory, T3, T4, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterKubeSchedulerConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterKubeSchedulerConfigFactory, T4, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterKubeSchedulerConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterKubeSchedulerConfigFactory, InnerClusterNodeResourcesFitConfigFactory> WithNodeResourcesFit<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterKubeSchedulerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.NodeResourcesFitConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNodeResourcesFit(combinedResult.T5, subFactoryAction).T2);
}
