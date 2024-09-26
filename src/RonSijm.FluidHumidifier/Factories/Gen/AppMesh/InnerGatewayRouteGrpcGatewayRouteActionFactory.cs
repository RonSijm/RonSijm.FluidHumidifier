// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGrpcGatewayRouteActionFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction>
{

    internal InnerGatewayRouteGatewayRouteTargetFactory TargetFactory { get; set; }

    internal InnerGatewayRouteGrpcGatewayRouteRewriteFactory RewriteFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction Create()
    {
        var grpcGatewayRouteActionResult = CreateGrpcGatewayRouteAction();
        factoryAction?.Invoke(grpcGatewayRouteActionResult);

        return grpcGatewayRouteActionResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction CreateGrpcGatewayRouteAction()
    {
        var grpcGatewayRouteActionResult = new Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction();

        return grpcGatewayRouteActionResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
        result.Rewrite ??= RewriteFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteGrpcGatewayRouteActionFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget(this InnerGatewayRouteGrpcGatewayRouteActionFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerGatewayRouteGatewayRouteTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite(this InnerGatewayRouteGrpcGatewayRouteActionFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null)
    {
        parentFactory.RewriteFactory = new InnerGatewayRouteGrpcGatewayRouteRewriteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RewriteFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, T4, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory, InnerGatewayRouteGrpcGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T5, subFactoryAction));
}
