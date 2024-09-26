// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerNetworkRouteFactory(Action<Humidifier.MediaLive.NetworkTypes.Route> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.NetworkTypes.Route>
{

    protected override Humidifier.MediaLive.NetworkTypes.Route Create()
    {
        var routeResult = CreateRoute();
        factoryAction?.Invoke(routeResult);

        return routeResult;
    }

    private Humidifier.MediaLive.NetworkTypes.Route CreateRoute()
    {
        var routeResult = new Humidifier.MediaLive.NetworkTypes.Route();

        return routeResult;
    }

} // End Of Class

public static class InnerNetworkRouteFactoryExtensions
{
}
