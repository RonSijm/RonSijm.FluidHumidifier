// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteHttpTimeoutFactory(Action<Humidifier.AppMesh.RouteTypes.HttpTimeout> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.HttpTimeout>
{

    internal InnerRouteDurationFactory PerRequestFactory { get; set; }

    internal InnerRouteDurationFactory IdleFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.HttpTimeout Create()
    {
        var httpTimeoutResult = CreateHttpTimeout();
        factoryAction?.Invoke(httpTimeoutResult);

        return httpTimeoutResult;
    }

    private Humidifier.AppMesh.RouteTypes.HttpTimeout CreateHttpTimeout()
    {
        var httpTimeoutResult = new Humidifier.AppMesh.RouteTypes.HttpTimeout();

        return httpTimeoutResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.HttpTimeout result)
    {
        base.CreateChildren(result);

        result.PerRequest ??= PerRequestFactory?.Build();
        result.Idle ??= IdleFactory?.Build();
    }

} // End Of Class

public static class InnerRouteHttpTimeoutFactoryExtensions
{
    public static CombinedResult<InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithPerRequest(this InnerRouteHttpTimeoutFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.PerRequestFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PerRequestFactory);
    }

    public static CombinedResult<InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithIdle(this InnerRouteHttpTimeoutFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.IdleFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleFactory);
    }

    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, InnerRouteDurationFactory> WithPerRequest<T1>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, T4, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithPerRequest<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPerRequest(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<InnerRouteHttpTimeoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteHttpTimeoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteHttpTimeoutFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteHttpTimeoutFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteHttpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteHttpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T5, subFactoryAction));
}
