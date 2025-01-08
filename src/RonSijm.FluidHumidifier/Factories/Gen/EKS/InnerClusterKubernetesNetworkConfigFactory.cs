// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterKubernetesNetworkConfigFactory(Action<Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig>
{

    internal InnerClusterElasticLoadBalancingFactory ElasticLoadBalancingFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig Create()
    {
        var kubernetesNetworkConfigResult = CreateKubernetesNetworkConfig();
        factoryAction?.Invoke(kubernetesNetworkConfigResult);

        return kubernetesNetworkConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig CreateKubernetesNetworkConfig()
    {
        var kubernetesNetworkConfigResult = new Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig();

        return kubernetesNetworkConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.KubernetesNetworkConfig result)
    {
        base.CreateChildren(result);

        result.ElasticLoadBalancing ??= ElasticLoadBalancingFactory?.Build();
    }

} // End Of Class

public static class InnerClusterKubernetesNetworkConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterKubernetesNetworkConfigFactory, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing(this InnerClusterKubernetesNetworkConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null)
    {
        parentFactory.ElasticLoadBalancingFactory = new InnerClusterElasticLoadBalancingFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ElasticLoadBalancingFactory);
    }

    public static CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1>(this CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1>(this CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2>(this CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2>(this CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2>(this CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2, T3, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3>(this CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2, T3, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3>(this CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory, T3, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterKubernetesNetworkConfigFactory, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterKubernetesNetworkConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2, T3, T4, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3, T4>(this CombinedResult<InnerClusterKubernetesNetworkConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2, T3, T4, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterKubernetesNetworkConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory, T3, T4, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterKubernetesNetworkConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerClusterKubernetesNetworkConfigFactory, T4, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterKubernetesNetworkConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerClusterKubernetesNetworkConfigFactory, InnerClusterElasticLoadBalancingFactory> WithElasticLoadBalancing<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterKubernetesNetworkConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithElasticLoadBalancing(combinedResult.T5, subFactoryAction));
}
