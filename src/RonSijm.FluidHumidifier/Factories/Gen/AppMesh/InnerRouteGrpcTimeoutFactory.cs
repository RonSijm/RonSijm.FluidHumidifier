// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteGrpcTimeoutFactory(Action<Humidifier.AppMesh.RouteTypes.GrpcTimeout> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.GrpcTimeout>
{

    internal InnerRouteDurationFactory PerRequestFactory { get; set; }

    internal InnerRouteDurationFactory IdleFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.GrpcTimeout Create()
    {
        var grpcTimeoutResult = CreateGrpcTimeout();
        factoryAction?.Invoke(grpcTimeoutResult);

        return grpcTimeoutResult;
    }

    private Humidifier.AppMesh.RouteTypes.GrpcTimeout CreateGrpcTimeout()
    {
        var grpcTimeoutResult = new Humidifier.AppMesh.RouteTypes.GrpcTimeout();

        return grpcTimeoutResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.GrpcTimeout result)
    {
        base.CreateChildren(result);

        result.PerRequest ??= PerRequestFactory?.Build();
        result.Idle ??= IdleFactory?.Build();
    }

} // End Of Class

public static class InnerRouteGrpcTimeoutFactoryExtensions
{
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithPerRequest(this InnerRouteGrpcTimeoutFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.PerRequestFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PerRequestFactory);
    }

    public static CombinedResult<InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithIdle(this InnerRouteGrpcTimeoutFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.IdleFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleFactory);
    }

    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, InnerRouteDurationFactory> WithPerRequest<T1>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<InnerRouteGrpcTimeoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteGrpcTimeoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteGrpcTimeoutFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteGrpcTimeoutFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteGrpcTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteGrpcTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T5, subFactoryAction));
}
