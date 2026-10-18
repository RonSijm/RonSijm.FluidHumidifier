// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteGatewayRouteHostnameMatchFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch Create()
    {
        var gatewayRouteHostnameMatchResult = CreateGatewayRouteHostnameMatch();
        factoryAction?.Invoke(gatewayRouteHostnameMatchResult);

        return gatewayRouteHostnameMatchResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch CreateGatewayRouteHostnameMatch()
    {
        var gatewayRouteHostnameMatchResult = new Humidifier.AppMesh.GatewayRouteTypes.GatewayRouteHostnameMatch();

        return gatewayRouteHostnameMatchResult;
    }

} // End Of Class

public static class InnerGatewayRouteGatewayRouteHostnameMatchFactoryExtensions
{
}
