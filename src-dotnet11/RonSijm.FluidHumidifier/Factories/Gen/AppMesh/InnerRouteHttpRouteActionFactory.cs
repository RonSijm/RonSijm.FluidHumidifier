// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteHttpRouteActionFactory(Action<Humidifier.AppMesh.RouteTypes.HttpRouteAction> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.HttpRouteAction>
{

    protected override Humidifier.AppMesh.RouteTypes.HttpRouteAction Create()
    {
        var httpRouteActionResult = CreateHttpRouteAction();
        factoryAction?.Invoke(httpRouteActionResult);

        return httpRouteActionResult;
    }

    private Humidifier.AppMesh.RouteTypes.HttpRouteAction CreateHttpRouteAction()
    {
        var httpRouteActionResult = new Humidifier.AppMesh.RouteTypes.HttpRouteAction();

        return httpRouteActionResult;
    }

} // End Of Class

public static class InnerRouteHttpRouteActionFactoryExtensions
{
}
