// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RefactorSpaces;

public class RouteFactory(string resourceName = null, Action<Humidifier.RefactorSpaces.Route> factoryAction = null) : ResourceFactory<Humidifier.RefactorSpaces.Route>(resourceName)
{

    internal InnerRouteUriPathRouteInputFactory UriPathRouteFactory { get; set; }

    internal InnerRouteDefaultRouteInputFactory DefaultRouteFactory { get; set; }

    protected override Humidifier.RefactorSpaces.Route Create()
    {
        var routeResult = CreateRoute();
        factoryAction?.Invoke(routeResult);

        return routeResult;
    }

    private Humidifier.RefactorSpaces.Route CreateRoute()
    {
        var routeResult = new Humidifier.RefactorSpaces.Route
        {
            GivenName = InputResourceName,
        };

        return routeResult;
    }
    public override void CreateChildren(Humidifier.RefactorSpaces.Route result)
    {
        base.CreateChildren(result);

        result.UriPathRoute ??= UriPathRouteFactory?.Build();
        result.DefaultRoute ??= DefaultRouteFactory?.Build();
    }

} // End Of Class

public static class RouteFactoryExtensions
{
    public static CombinedResult<RouteFactory, InnerRouteUriPathRouteInputFactory> WithUriPathRoute(this RouteFactory parentFactory, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null)
    {
        parentFactory.UriPathRouteFactory = new InnerRouteUriPathRouteInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UriPathRouteFactory);
    }

    public static CombinedResult<RouteFactory, InnerRouteDefaultRouteInputFactory> WithDefaultRoute(this RouteFactory parentFactory, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null)
    {
        parentFactory.DefaultRouteFactory = new InnerRouteDefaultRouteInputFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DefaultRouteFactory);
    }

    public static CombinedResult<RouteFactory, T1, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1>(this CombinedResult<RouteFactory, T1> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithUriPathRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1>(this CombinedResult<T1, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithUriPathRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2>(this CombinedResult<RouteFactory, T1, T2> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2>(this CombinedResult<T1, RouteFactory, T2> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2>(this CombinedResult<T1, T2, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3>(this CombinedResult<RouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3>(this CombinedResult<T1, RouteFactory, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3>(this CombinedResult<T1, T2, RouteFactory, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3>(this CombinedResult<T1, T2, T3, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, T4, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3, T4>(this CombinedResult<RouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, T4, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3, T4>(this CombinedResult<T1, RouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, T4, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, RouteFactory, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, T4, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RouteFactory, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RouteFactory, InnerRouteUriPathRouteInputFactory> WithUriPathRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.UriPathRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUriPathRoute(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1>(this CombinedResult<RouteFactory, T1> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1>(this CombinedResult<T1, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, WithDefaultRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2>(this CombinedResult<RouteFactory, T1, T2> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2>(this CombinedResult<T1, RouteFactory, T2> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2>(this CombinedResult<T1, T2, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3>(this CombinedResult<RouteFactory, T1, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3>(this CombinedResult<T1, RouteFactory, T2, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3>(this CombinedResult<T1, T2, RouteFactory, T3> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3>(this CombinedResult<T1, T2, T3, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RouteFactory, T1, T2, T3, T4, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3, T4>(this CombinedResult<RouteFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RouteFactory, T2, T3, T4, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3, T4>(this CombinedResult<T1, RouteFactory, T2, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RouteFactory, T3, T4, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, RouteFactory, T3, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RouteFactory, T4, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RouteFactory, T4> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RouteFactory, InnerRouteDefaultRouteInputFactory> WithDefaultRoute<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RouteFactory> combinedResult, Action<Humidifier.RefactorSpaces.RouteTypes.DefaultRouteInput> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDefaultRoute(combinedResult.T5, subFactoryAction));
}
