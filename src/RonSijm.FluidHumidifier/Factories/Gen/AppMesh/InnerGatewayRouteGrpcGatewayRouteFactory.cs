// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGrpcGatewayRouteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute>
{

    internal InnerGatewayRouteGrpcGatewayRouteActionFactory ActionFactory { get; set; }

    internal InnerGatewayRouteGrpcGatewayRouteMatchFactory MatchFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute Create()
    {
        var grpcGatewayRouteResult = CreateGrpcGatewayRoute();
        factoryAction?.Invoke(grpcGatewayRouteResult);

        return grpcGatewayRouteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute CreateGrpcGatewayRoute()
    {
        var grpcGatewayRouteResult = new Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute();

        return grpcGatewayRouteResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRoute result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteGrpcGatewayRouteFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction(this InnerGatewayRouteGrpcGatewayRouteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerGatewayRouteGrpcGatewayRouteActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch(this InnerGatewayRouteGrpcGatewayRouteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerGatewayRouteGrpcGatewayRouteMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, T4, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteGrpcGatewayRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteGrpcGatewayRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteGrpcGatewayRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, T4, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteGrpcGatewayRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteFactory, InnerGatewayRouteGrpcGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteGrpcGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.GrpcGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}
