// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterKubeApiServerConfigFactory(Action<Humidifier.EKS.ClusterTypes.KubeApiServerConfig> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.KubeApiServerConfig>
{

    internal InnerClusterServiceNodePortRangeFactory ServiceNodePortRangeFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.KubeApiServerConfig Create()
    {
        var kubeApiServerConfigResult = CreateKubeApiServerConfig();
        factoryAction?.Invoke(kubeApiServerConfigResult);

        return kubeApiServerConfigResult;
    }

    private Humidifier.EKS.ClusterTypes.KubeApiServerConfig CreateKubeApiServerConfig()
    {
        var kubeApiServerConfigResult = new Humidifier.EKS.ClusterTypes.KubeApiServerConfig();

        return kubeApiServerConfigResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.KubeApiServerConfig result)
    {
        base.CreateChildren(result);

        result.ServiceNodePortRange ??= ServiceNodePortRangeFactory?.Build();
    }

} // End Of Class

public static class InnerClusterKubeApiServerConfigFactoryExtensions
{
    public static CombinedResult<InnerClusterKubeApiServerConfigFactory, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange(this InnerClusterKubeApiServerConfigFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null)
    {
        parentFactory.ServiceNodePortRangeFactory = new InnerClusterServiceNodePortRangeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ServiceNodePortRangeFactory);
    }

    public static CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1>(this CombinedResult<InnerClusterKubeApiServerConfigFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1>(this CombinedResult<T1, InnerClusterKubeApiServerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2>(this CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2>(this CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2>(this CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2, T3, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3>(this CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2, T3, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3>(this CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory, T3, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterKubeApiServerConfigFactory, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterKubeApiServerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2, T3, T4, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3, T4>(this CombinedResult<InnerClusterKubeApiServerConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2, T3, T4, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterKubeApiServerConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory, T3, T4, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterKubeApiServerConfigFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterKubeApiServerConfigFactory, T4, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterKubeApiServerConfigFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterKubeApiServerConfigFactory, InnerClusterServiceNodePortRangeFactory> WithServiceNodePortRange<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterKubeApiServerConfigFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.ServiceNodePortRange> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithServiceNodePortRange(combinedResult.T5, subFactoryAction).T2);
}
