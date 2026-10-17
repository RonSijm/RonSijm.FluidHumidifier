// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteServerPropagationFactory(string resourceName = null, Action<Humidifier.EC2.RouteServerPropagation> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteServerPropagation>(resourceName)
{

    protected override Humidifier.EC2.RouteServerPropagation Create()
    {
        var routeServerPropagationResult = CreateRouteServerPropagation();
        factoryAction?.Invoke(routeServerPropagationResult);

        return routeServerPropagationResult;
    }

    private Humidifier.EC2.RouteServerPropagation CreateRouteServerPropagation()
    {
        var routeServerPropagationResult = new Humidifier.EC2.RouteServerPropagation
        {
            GivenName = InputResourceName,
        };

        return routeServerPropagationResult;
    }

} // End Of Class

public static class RouteServerPropagationFactoryExtensions
{
}
