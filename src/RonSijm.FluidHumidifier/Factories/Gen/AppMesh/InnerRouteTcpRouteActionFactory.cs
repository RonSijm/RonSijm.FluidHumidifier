// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteTcpRouteActionFactory(Action<Humidifier.AppMesh.RouteTypes.TcpRouteAction> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.TcpRouteAction>
{

    protected override Humidifier.AppMesh.RouteTypes.TcpRouteAction Create()
    {
        var tcpRouteActionResult = CreateTcpRouteAction();
        factoryAction?.Invoke(tcpRouteActionResult);

        return tcpRouteActionResult;
    }

    private Humidifier.AppMesh.RouteTypes.TcpRouteAction CreateTcpRouteAction()
    {
        var tcpRouteActionResult = new Humidifier.AppMesh.RouteTypes.TcpRouteAction();

        return tcpRouteActionResult;
    }

} // End Of Class

public static class InnerRouteTcpRouteActionFactoryExtensions
{
}
