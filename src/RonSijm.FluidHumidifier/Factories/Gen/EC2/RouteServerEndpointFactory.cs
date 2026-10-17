// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteServerEndpointFactory(string resourceName = null, Action<Humidifier.EC2.RouteServerEndpoint> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteServerEndpoint>(resourceName)
{

    protected override Humidifier.EC2.RouteServerEndpoint Create()
    {
        var routeServerEndpointResult = CreateRouteServerEndpoint();
        factoryAction?.Invoke(routeServerEndpointResult);

        return routeServerEndpointResult;
    }

    private Humidifier.EC2.RouteServerEndpoint CreateRouteServerEndpoint()
    {
        var routeServerEndpointResult = new Humidifier.EC2.RouteServerEndpoint
        {
            GivenName = InputResourceName,
        };

        return routeServerEndpointResult;
    }

} // End Of Class

public static class RouteServerEndpointFactoryExtensions
{
}
