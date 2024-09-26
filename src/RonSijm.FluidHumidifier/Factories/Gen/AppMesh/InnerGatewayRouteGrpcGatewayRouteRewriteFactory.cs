// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGrpcGatewayRouteRewriteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite>
{

    internal InnerGatewayRouteGatewayRouteHostnameRewriteFactory HostnameFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite Create()
    {
        var grpcGatewayRouteRewriteResult = CreateGrpcGatewayRouteRewrite();
        factoryAction?.Invoke(grpcGatewayRouteRewriteResult);

        return grpcGatewayRouteRewriteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite CreateGrpcGatewayRouteRewrite()
    {
        var grpcGatewayRouteRewriteResult = new Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite();

        return grpcGatewayRouteRewriteResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite result)
    {
        base.CreateChildren(result);

        result.Hostname ??= HostnameFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteGrpcGatewayRouteRewriteFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname(this InnerGatewayRouteGrpcGatewayRouteRewriteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null)
    {
        parentFactory.HostnameFactory = new InnerGatewayRouteGatewayRouteHostnameRewriteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HostnameFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2, T3, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T3, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T3, T4, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T4, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory, InnerGatewayRouteGatewayRouteHostnameRewriteFactory> WithHostname<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHostname(combinedResult.T5, subFactoryAction));
}
