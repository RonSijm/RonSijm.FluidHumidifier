// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGatewayRouteVirtualServiceFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService Create()
    {
        var gatewayRouteVirtualServiceResult = CreateGatewayRouteVirtualService();
        factoryAction?.Invoke(gatewayRouteVirtualServiceResult);

        return gatewayRouteVirtualServiceResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService CreateGatewayRouteVirtualService()
    {
        var gatewayRouteVirtualServiceResult = new Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteVirtualService();

        return gatewayRouteVirtualServiceResult;
    }

} // End Of Class

public static class InnerGatewayRouteGatewayRouteVirtualServiceFactoryExtensions
{
}
