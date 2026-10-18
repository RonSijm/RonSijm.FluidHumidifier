// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpGatewayRoutePrefixRewriteFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePrefixRewrite> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePrefixRewrite>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePrefixRewrite Create()
    {
        var httpGatewayRoutePrefixRewriteResult = CreateHttpGatewayRoutePrefixRewrite();
        factoryAction?.Invoke(httpGatewayRoutePrefixRewriteResult);

        return httpGatewayRoutePrefixRewriteResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePrefixRewrite CreateHttpGatewayRoutePrefixRewrite()
    {
        var httpGatewayRoutePrefixRewriteResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpGatewayRoutePrefixRewrite();

        return httpGatewayRoutePrefixRewriteResult;
    }

} // End Of Class

public static class InnerGatewayRouteHttpGatewayRoutePrefixRewriteFactoryExtensions
{
}
