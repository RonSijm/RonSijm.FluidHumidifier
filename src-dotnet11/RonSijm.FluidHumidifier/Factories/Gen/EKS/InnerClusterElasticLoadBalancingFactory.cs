// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterElasticLoadBalancingFactory(Action<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.ElasticLoadBalancing>
{

    internal InnerClusterGatewayApiFactory GatewayApiFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.ElasticLoadBalancing Create()
    {
        var elasticLoadBalancingResult = CreateElasticLoadBalancing();
        factoryAction?.Invoke(elasticLoadBalancingResult);

        return elasticLoadBalancingResult;
    }

    private Humidifier.EKS.ClusterTypes.ElasticLoadBalancing CreateElasticLoadBalancing()
    {
        var elasticLoadBalancingResult = new Humidifier.EKS.ClusterTypes.ElasticLoadBalancing();

        return elasticLoadBalancingResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.ElasticLoadBalancing result)
    {
        base.CreateChildren(result);

        result.GatewayApi ??= GatewayApiFactory?.Build();
    }

} // End Of Class

public static class InnerClusterElasticLoadBalancingFactoryExtensions
{
    public static CombinedResult<InnerClusterElasticLoadBalancingFactory, InnerClusterGatewayApiFactory> WithGatewayApi(this InnerClusterElasticLoadBalancingFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null)
    {
        parentFactory.GatewayApiFactory = new InnerClusterGatewayApiFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GatewayApiFactory);
    }

    public static CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, InnerClusterGatewayApiFactory> WithGatewayApi<T1>(this CombinedResult<InnerClusterElasticLoadBalancingFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, InnerClusterGatewayApiFactory> WithGatewayApi<T1>(this CombinedResult<T1, InnerClusterElasticLoadBalancingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatewayApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2>(this CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2>(this CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2>(this CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2, T3, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3>(this CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2, T3, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3>(this CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory, T3, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterElasticLoadBalancingFactory, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterElasticLoadBalancingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2, T3, T4, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3, T4>(this CombinedResult<InnerClusterElasticLoadBalancingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2, T3, T4, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterElasticLoadBalancingFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory, T3, T4, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterElasticLoadBalancingFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterElasticLoadBalancingFactory, T4, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterElasticLoadBalancingFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterElasticLoadBalancingFactory, InnerClusterGatewayApiFactory> WithGatewayApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterElasticLoadBalancingFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatewayApi(combinedResult.T5, subFactoryAction).T2);
}
