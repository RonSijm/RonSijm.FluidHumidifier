// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGatewayRouteHostnameRewriteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite Create()
    {
        var gatewayRouteHostnameRewriteResult = CreateGatewayRouteHostnameRewrite();
        factoryAction?.Invoke(gatewayRouteHostnameRewriteResult);

        return gatewayRouteHostnameRewriteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite CreateGatewayRouteHostnameRewrite()
    {
        var gatewayRouteHostnameRewriteResult = new Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameRewrite();

        return gatewayRouteHostnameRewriteResult;
    }

} // End Of Class

public static class InnerGatewayRouteGatewayRouteHostnameRewriteFactoryExtensions
{
}
