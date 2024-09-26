// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpGatewayRoutePathRewriteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePathRewrite> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePathRewrite>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePathRewrite Create()
    {
        var httpGatewayRoutePathRewriteResult = CreateHttpGatewayRoutePathRewrite();
        factoryAction?.Invoke(httpGatewayRoutePathRewriteResult);

        return httpGatewayRoutePathRewriteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePathRewrite CreateHttpGatewayRoutePathRewrite()
    {
        var httpGatewayRoutePathRewriteResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePathRewrite();

        return httpGatewayRoutePathRewriteResult;
    }

} // End Of Class

public static class InnerGatewayRouteHttpGatewayRoutePathRewriteFactoryExtensions
{
}
