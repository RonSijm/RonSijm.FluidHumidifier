// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class RouteServerAssociationFactory(string resourceName = null, Action<Humidifier.EC2.RouteServerAssociation> factoryAction = null) : ResourceFactory<Humidifier.EC2.RouteServerAssociation>(resourceName)
{

    protected override Humidifier.EC2.RouteServerAssociation Create()
    {
        var routeServerAssociationResult = CreateRouteServerAssociation();
        factoryAction?.Invoke(routeServerAssociationResult);

        return routeServerAssociationResult;
    }

    private Humidifier.EC2.RouteServerAssociation CreateRouteServerAssociation()
    {
        var routeServerAssociationResult = new Humidifier.EC2.RouteServerAssociation
        {
            GivenName = InputResourceName,
        };

        return routeServerAssociationResult;
    }

} // End Of Class

public static class RouteServerAssociationFactoryExtensions
{
}
