// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteTcpRouteFactory(Action<Humidifier.AppMesh.RouteTypes.TcpRoute> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.TcpRoute>
{

    internal InnerRouteTcpRouteActionFactory ActionFactory { get; set; }

    internal InnerRouteTcpTimeoutFactory TimeoutFactory { get; set; }

    internal InnerRouteTcpRouteMatchFactory MatchFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.TcpRoute Create()
    {
        var tcpRouteResult = CreateTcpRoute();
        factoryAction?.Invoke(tcpRouteResult);

        return tcpRouteResult;
    }

    private Humidifier.AppMesh.RouteTypes.TcpRoute CreateTcpRoute()
    {
        var tcpRouteResult = new Humidifier.AppMesh.RouteTypes.TcpRoute();

        return tcpRouteResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.TcpRoute result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Timeout ??= TimeoutFactory?.Build();
        result.Match ??= MatchFactory?.Build();
    }

} // End Of Class

public static class InnerRouteTcpRouteFactoryExtensions
{
    public static CombinedResult<InnerRouteTcpRouteFactory, InnerRouteTcpRouteActionFactory> WithAction(this InnerRouteTcpRouteFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerRouteTcpRouteActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerRouteTcpRouteFactory, InnerRouteTcpTimeoutFactory> WithTimeout(this InnerRouteTcpRouteFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null)
    {
        parentFactory.TimeoutFactory = new InnerRouteTcpTimeoutFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TimeoutFactory);
    }

    public static CombinedResult<InnerRouteTcpRouteFactory, InnerRouteTcpRouteMatchFactory> WithMatch(this InnerRouteTcpRouteFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null)
    {
        parentFactory.MatchFactory = new InnerRouteTcpRouteMatchFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchFactory);
    }

    public static CombinedResult<InnerRouteTcpRouteFactory, T1, InnerRouteTcpRouteActionFactory> WithAction<T1>(this CombinedResult<InnerRouteTcpRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, InnerRouteTcpRouteActionFactory> WithAction<T1>(this CombinedResult<T1, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, InnerRouteTcpRouteActionFactory> WithAction<T1, T2>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, InnerRouteTcpRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, InnerRouteTcpRouteActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory, InnerRouteTcpRouteActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, InnerRouteTcpTimeoutFactory> WithTimeout<T1>(this CombinedResult<InnerRouteTcpRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, InnerRouteTcpTimeoutFactory> WithTimeout<T1>(this CombinedResult<T1, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, WithTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3, T4>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory, InnerRouteTcpTimeoutFactory> WithTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTimeout(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, InnerRouteTcpRouteMatchFactory> WithMatch<T1>(this CombinedResult<InnerRouteTcpRouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, InnerRouteTcpRouteMatchFactory> WithMatch<T1>(this CombinedResult<T1, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<InnerRouteTcpRouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteTcpRouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteTcpRouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteTcpRouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory, InnerRouteTcpRouteMatchFactory> WithMatch<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteTcpRouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatch(combinedResult.T5, subFactoryAction));
}
