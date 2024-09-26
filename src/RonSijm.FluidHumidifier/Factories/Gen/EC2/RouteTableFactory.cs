// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteTableFactory(string resourceName = null, Action<Humidifier.EC2.RouteTable> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteTable>(resourceName)
{

    protected override Humidifier.EC2.RouteTable Create()
    {
        var routeTableResult = CreateRouteTable();
        factoryAction?.Invoke(routeTableResult);

        return routeTableResult;
    }

    private Humidifier.EC2.RouteTable CreateRouteTable()
    {
        var routeTableResult = new Humidifier.EC2.RouteTable
        {
            GivenName = InputResourceName,
        };

        return routeTableResult;
    }

} // End Of Class

public static class RouteTableFactoryExtensions
{
}
