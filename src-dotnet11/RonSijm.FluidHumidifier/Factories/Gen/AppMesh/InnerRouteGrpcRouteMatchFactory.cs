// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteGrpcRouteMatchFactory(Action<Humidifier.AppMesh.RouteTypes.GrpcRouteMatch> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.GrpcRouteMatch>
{

    protected override Humidifier.AppMesh.RouteTypes.GrpcRouteMatch Create()
    {
        var grpcRouteMatchResult = CreateGrpcRouteMatch();
        factoryAction?.Invoke(grpcRouteMatchResult);

        return grpcRouteMatchResult;
    }

    private Humidifier.AppMesh.RouteTypes.GrpcRouteMatch CreateGrpcRouteMatch()
    {
        var grpcRouteMatchResult = new Humidifier.AppMesh.RouteTypes.GrpcRouteMatch();

        return grpcRouteMatchResult;
    }

} // End Of Class

public static class InnerRouteGrpcRouteMatchFactoryExtensions
{
}
