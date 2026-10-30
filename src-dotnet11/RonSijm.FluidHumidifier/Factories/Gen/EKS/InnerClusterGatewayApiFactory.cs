// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class InnerClusterGatewayApiFactory(Action<Humidifier.EKS.ClusterTypes.GatewayApi> factoryAction = null) : SubResourceFactory<Humidifier.EKS.ClusterTypes.GatewayApi>
{

    internal InnerClusterGatewayApiCrdsFactory CrdsFactory { get; set; }

    protected override Humidifier.EKS.ClusterTypes.GatewayApi Create()
    {
        var gatewayApiResult = CreateGatewayApi();
        factoryAction?.Invoke(gatewayApiResult);

        return gatewayApiResult;
    }

    private Humidifier.EKS.ClusterTypes.GatewayApi CreateGatewayApi()
    {
        var gatewayApiResult = new Humidifier.EKS.ClusterTypes.GatewayApi();

        return gatewayApiResult;
    }
    public override void CreateChildren(Humidifier.EKS.ClusterTypes.GatewayApi result)
    {
        base.CreateChildren(result);

        result.Crds ??= CrdsFactory?.Build();
    }

} // End Of Class

public static class InnerClusterGatewayApiFactoryExtensions
{
    public static CombinedResult<InnerClusterGatewayApiFactory, InnerClusterGatewayApiCrdsFactory> WithCrds(this InnerClusterGatewayApiFactory parentFactory, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null)
    {
        parentFactory.CrdsFactory = new InnerClusterGatewayApiCrdsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrdsFactory);
    }

    public static CombinedResult<InnerClusterGatewayApiFactory, T1, InnerClusterGatewayApiCrdsFactory> WithCrds<T1>(this CombinedResult<InnerClusterGatewayApiFactory, T1> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrds(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterGatewayApiFactory, InnerClusterGatewayApiCrdsFactory> WithCrds<T1>(this CombinedResult<T1, InnerClusterGatewayApiFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrds(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerClusterGatewayApiFactory, T1, T2, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2>(this CombinedResult<InnerClusterGatewayApiFactory, T1, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterGatewayApiFactory, T2, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2>(this CombinedResult<T1, InnerClusterGatewayApiFactory, T2> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterGatewayApiFactory, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2>(this CombinedResult<T1, T2, InnerClusterGatewayApiFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerClusterGatewayApiFactory, T1, T2, T3, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3>(this CombinedResult<InnerClusterGatewayApiFactory, T1, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterGatewayApiFactory, T2, T3, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3>(this CombinedResult<T1, InnerClusterGatewayApiFactory, T2, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterGatewayApiFactory, T3, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3>(this CombinedResult<T1, T2, InnerClusterGatewayApiFactory, T3> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterGatewayApiFactory, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerClusterGatewayApiFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerClusterGatewayApiFactory, T1, T2, T3, T4, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3, T4>(this CombinedResult<InnerClusterGatewayApiFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerClusterGatewayApiFactory, T2, T3, T4, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3, T4>(this CombinedResult<T1, InnerClusterGatewayApiFactory, T2, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerClusterGatewayApiFactory, T3, T4, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerClusterGatewayApiFactory, T3, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerClusterGatewayApiFactory, T4, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerClusterGatewayApiFactory, T4> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerClusterGatewayApiFactory, InnerClusterGatewayApiCrdsFactory> WithCrds<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerClusterGatewayApiFactory> combinedResult, Action<Humidifier.EKS.ClusterTypes.GatewayApiCrds> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrds(combinedResult.T5, subFactoryAction).T2);
}
