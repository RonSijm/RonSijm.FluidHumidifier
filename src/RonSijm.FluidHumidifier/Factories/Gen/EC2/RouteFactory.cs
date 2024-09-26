// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteFactory(string resourceName = null, Action<Humidifier.EC2.Route> factoryAction = null) : ResourceFactory<Humidifier.EC2.Route>(resourceName)
{

    protected override Humidifier.EC2.Route Create()
    {
        var routeResult = CreateRoute();
        factoryAction?.Invoke(routeResult);

        return routeResult;
    }

    private Humidifier.EC2.Route CreateRoute()
    {
        var routeResult = new Humidifier.EC2.Route
        {
            GivenName = InputResourceName,
        };

        return routeResult;
    }

} // End Of Class

public static class RouteFactoryExtensions
{
}
