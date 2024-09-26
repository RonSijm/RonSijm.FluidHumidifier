// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteGrpcRouteActionFactory(Action<Humidifier.AppMesh.RouteTypes.GrpcRouteAction> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.GrpcRouteAction>
{

    protected override Humidifier.AppMesh.RouteTypes.GrpcRouteAction Create()
    {
        var grpcRouteActionResult = CreateGrpcRouteAction();
        factoryAction?.Invoke(grpcRouteActionResult);

        return grpcRouteActionResult;
    }

    private Humidifier.AppMesh.RouteTypes.GrpcRouteAction CreateGrpcRouteAction()
    {
        var grpcRouteActionResult = new Humidifier.AppMesh.RouteTypes.GrpcRouteAction();

        return grpcRouteActionResult;
    }

} // End Of Class

public static class InnerRouteGrpcRouteActionFactoryExtensions
{
}
