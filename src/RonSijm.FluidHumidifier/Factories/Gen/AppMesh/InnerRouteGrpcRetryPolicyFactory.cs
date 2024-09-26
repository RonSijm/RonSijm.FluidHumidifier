// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteGrpcRetryPolicyFactory(Action<Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy>
{

    internal InnerRouteDurationFactory PerRetryTimeoutFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy Create()
    {
        var grpcRetryPolicyResult = CreateGrpcRetryPolicy();
        factoryAction?.Invoke(grpcRetryPolicyResult);

        return grpcRetryPolicyResult;
    }

    private Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy CreateGrpcRetryPolicy()
    {
        var grpcRetryPolicyResult = new Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy();

        return grpcRetryPolicyResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.GrpcRetryPolicy result)
    {
        base.CreateChildren(result);

        result.PerRetryTimeout ??= PerRetryTimeoutFactory?.Build();
    }

} // End Of Class

public static class InnerRouteGrpcRetryPolicyFactoryExtensions
{
    public static CombinedResult<InnerRouteGrpcRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout(this InnerRouteGrpcRetryPolicyFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.PerRetryTimeoutFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PerRetryTimeoutFactory);
    }

    public static CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, InnerRouteDurationFactory> WithPerRetryTimeout<T1>(this CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1>(this CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteGrpcRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<InnerRouteGrpcRetryPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteGrpcRetryPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteGrpcRetryPolicyFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteGrpcRetryPolicyFactory, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteGrpcRetryPolicyFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteGrpcRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteGrpcRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T5, subFactoryAction));
}
