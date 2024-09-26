// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Location;

public class RouteCalculatorFactory(string resourceName = null, Action<Humidifier.Location.RouteCalculator> factoryAction = null) : ResourceFactory<Humidifier.Location.RouteCalculator>(resourceName)
{

    protected override Humidifier.Location.RouteCalculator Create()
    {
        var routeCalculatorResult = CreateRouteCalculator();
        factoryAction?.Invoke(routeCalculatorResult);

        return routeCalculatorResult;
    }

    private Humidifier.Location.RouteCalculator CreateRouteCalculator()
    {
        var routeCalculatorResult = new Humidifier.Location.RouteCalculator
        {
            GivenName = InputResourceName,
        };

        return routeCalculatorResult;
    }

} // End Of Class

public static class RouteCalculatorFactoryExtensions
{
}
