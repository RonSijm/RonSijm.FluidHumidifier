// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteHttpRetryPolicyFactory(Action<Humidifier.AppMesh.RouteTypes.HttpRetryPolicy> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.HttpRetryPolicy>
{

    internal InnerRouteDurationFactory PerRetryTimeoutFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.HttpRetryPolicy Create()
    {
        var httpRetryPolicyResult = CreateHttpRetryPolicy();
        factoryAction?.Invoke(httpRetryPolicyResult);

        return httpRetryPolicyResult;
    }

    private Humidifier.AppMesh.RouteTypes.HttpRetryPolicy CreateHttpRetryPolicy()
    {
        var httpRetryPolicyResult = new Humidifier.AppMesh.RouteTypes.HttpRetryPolicy();

        return httpRetryPolicyResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.HttpRetryPolicy result)
    {
        base.CreateChildren(result);

        result.PerRetryTimeout ??= PerRetryTimeoutFactory?.Build();
    }

} // End Of Class

public static class InnerRouteHttpRetryPolicyFactoryExtensions
{
    public static CombinedResult<InnerRouteHttpRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout(this InnerRouteHttpRetryPolicyFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.PerRetryTimeoutFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PerRetryTimeoutFactory);
    }

    public static CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, InnerRouteDurationFactory> WithPerRetryTimeout<T1>(this CombinedResult<InnerRouteHttpRetryPolicyFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1>(this CombinedResult<T1, InnerRouteHttpRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2>(this CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory, T3, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteHttpRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<InnerRouteHttpRetryPolicyFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteHttpRetryPolicyFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory, T3, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteHttpRetryPolicyFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpRetryPolicyFactory, T4, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteHttpRetryPolicyFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteHttpRetryPolicyFactory, InnerRouteDurationFactory> WithPerRetryTimeout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteHttpRetryPolicyFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRetryTimeout(combinedResult.T5, subFactoryAction));
}
