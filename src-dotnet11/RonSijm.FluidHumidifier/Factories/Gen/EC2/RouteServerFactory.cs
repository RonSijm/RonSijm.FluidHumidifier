// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteServerFactory(string resourceName = null, Action<Humidifier.EC2.RouteServer> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteServer>(resourceName)
{

    protected override Humidifier.EC2.RouteServer Create()
    {
        var routeServerResult = CreateRouteServer();
        factoryAction?.Invoke(routeServerResult);

        return routeServerResult;
    }

    private Humidifier.EC2.RouteServer CreateRouteServer()
    {
        var routeServerResult = new Humidifier.EC2.RouteServer
        {
            GivenName = InputResourceName,
        };

        return routeServerResult;
    }

} // End Of Class

public static class RouteServerFactoryExtensions
{
}
