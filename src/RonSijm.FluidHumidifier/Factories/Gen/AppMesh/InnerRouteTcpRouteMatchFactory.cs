// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteTcpRouteMatchFactory(Action<Humidifier.AppMesh.RouteTypes.TcpRouteMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.TcpRouteMatch>
{

    protected override Humidifier.AppMesh.RouteTypes.TcpRouteMatch Create()
    {
        var tcpRouteMatchResult = CreateTcpRouteMatch();
        factoryAction?.Invoke(tcpRouteMatchResult);

        return tcpRouteMatchResult;
    }

    private Humidifier.AppMesh.RouteTypes.TcpRouteMatch CreateTcpRouteMatch()
    {
        var tcpRouteMatchResult = new Humidifier.AppMesh.RouteTypes.TcpRouteMatch();

        return tcpRouteMatchResult;
    }

} // End Of Class

public static class InnerRouteTcpRouteMatchFactoryExtensions
{
}
