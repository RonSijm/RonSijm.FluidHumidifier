// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpGatewayRouteActionFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction>
{

    internal InnerGatewayRouteGatewayRouteTargetFactory TargetFactory { get; set; }

    internal InnerGatewayRouteHttpGatewayRouteRewriteFactory RewriteFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction Create()
    {
        var httpGatewayRouteActionResult = CreateHttpGatewayRouteAction();
        factoryAction?.Invoke(httpGatewayRouteActionResult);

        return httpGatewayRouteActionResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction CreateHttpGatewayRouteAction()
    {
        var httpGatewayRouteActionResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction();

        return httpGatewayRouteActionResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction result)
    {
        base.CreateChildren(result);

        result.Target ??= TargetFactory?.Build();
        result.Rewrite ??= RewriteFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteHttpGatewayRouteActionFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget(this InnerGatewayRouteHttpGatewayRouteActionFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null)
    {
        parentFactory.TargetFactory = new InnerGatewayRouteGatewayRouteTargetFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TargetFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite(this InnerGatewayRouteHttpGatewayRouteActionFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null)
    {
        parentFactory.RewriteFactory = new InnerGatewayRouteHttpGatewayRouteRewriteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RewriteFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, T4, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteGatewayRouteTargetFactory> WithTarget<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteTarget> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTarget(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, T4, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, T4, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory, InnerGatewayRouteHttpGatewayRouteRewriteFactory> WithRewrite<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteRewrite> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRewrite(combinedResult.T5, subFactoryAction));
}
