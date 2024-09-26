// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class RouteFactory(string resourceName = null, Action<Humidifier.AppMesh.Route> factoryAction = null) : ResourceFactory<Humidifier.AppMesh.Route>(resourceName)
{

    internal InnerRouteRouteSpecFactory SpecFactory { get; set; }

    protected override Humidifier.AppMesh.Route Create()
    {
        var routeResult = CreateRoute();
        factoryAction?.Invoke(routeResult);

        return routeResult;
    }

    private Humidifier.AppMesh.Route CreateRoute()
    {
        var routeResult = new Humidifier.AppMesh.Route
        {
            GivenName = InputResourceName,
        };

        return routeResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.Route result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
    }

} // End Of Class

public static class RouteFactoryExtensions
{
    public static CombinedResult<RouteFactory, InnerRouteRouteSpecFactory> WithSpec(this RouteFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerRouteRouteSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<RouteFactory, T1, InnerRouteRouteSpecFactory> WithSpec<T1>(this CombinedResult<RouteFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, InnerRouteRouteSpecFactory> WithSpec<T1>(this CombinedResult<T1, RouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, InnerRouteRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<RouteFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, InnerRouteRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, RouteFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, InnerRouteRouteSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, RouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<RouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, RouteFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, RouteFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, RouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, T4, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<RouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, T4, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, RouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, T4, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, RouteFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, T4, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RouteFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RouteFactory, InnerRouteRouteSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RouteFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.RouteSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction));
}
