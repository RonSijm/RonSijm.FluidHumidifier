// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteHttpPathMatchFactory(Action<Humidifier.AppMesh.RouteTypes.HttpPathMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.HttpPathMatch>
{

    protected override Humidifier.AppMesh.RouteTypes.HttpPathMatch Create()
    {
        var httpPathMatchResult = CreateHttpPathMatch();
        factoryAction?.Invoke(httpPathMatchResult);

        return httpPathMatchResult;
    }

    private Humidifier.AppMesh.RouteTypes.HttpPathMatch CreateHttpPathMatch()
    {
        var httpPathMatchResult = new Humidifier.AppMesh.RouteTypes.HttpPathMatch();

        return httpPathMatchResult;
    }

} // End Of Class

public static class InnerRouteHttpPathMatchFactoryExtensions
{
}
