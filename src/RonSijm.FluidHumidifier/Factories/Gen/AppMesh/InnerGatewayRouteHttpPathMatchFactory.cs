// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerGatewayRouteHttpPathMatchFactory(Action<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch>
{

    protected override Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch Create()
    {
        var httpPathMatchResult = CreateHttpPathMatch();
        factoryAction?.Invoke(httpPathMatchResult);

        return httpPathMatchResult;
    }

    private Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch CreateHttpPathMatch()
    {
        var httpPathMatchResult = new Humidifier.AppMesh.GatewayRouteTypes.HttpPathMatch();

        return httpPathMatchResult;
    }

} // End Of Class

public static class InnerGatewayRouteHttpPathMatchFactoryExtensions
{
}
