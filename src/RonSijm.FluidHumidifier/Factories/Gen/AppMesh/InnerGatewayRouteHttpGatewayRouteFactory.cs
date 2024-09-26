// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpGatewayRouteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute>
{

    internal InnerGatewayRouteHttpGatewayRouteActionFactory ActionFactory { get; set; }

    internal InnerGatewayRouteHttpGatewayRouteMatchFactory MatchFactory { get; set; }

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute Create()
    {
        var httpGatewayRouteResult = CreateHttpGatewayRoute();
        factoryAction?.Invoke(httpGatewayRouteResult);

        return httpGatewayRouteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute CreateHttpGatewayRoute()
    {
        var httpGatewayRouteResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute();

        return httpGatewayRouteResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoute result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRouteHttpGatewayRouteFactoryExtensions
{
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction(this InnerGatewayRouteHttpGatewayRouteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerGatewayRouteHttpGatewayRouteActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch(this InnerGatewayRouteHttpGatewayRouteFactory parentFactory, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerGatewayRouteHttpGatewayRouteMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, T4, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRouteHttpGatewayRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRouteHttpGatewayRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRouteHttpGatewayRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, T4, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRouteHttpGatewayRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteFactory, InnerGatewayRouteHttpGatewayRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRouteHttpGatewayRouteFactory> combinedResult, Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}
