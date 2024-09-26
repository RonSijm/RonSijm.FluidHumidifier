// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerRouteTcpTimeoutFactory(Action<Humidifier.AppMesh.RouteTypes.TcpTimeout> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.RouteTypes.TcpTimeout>
{

    internal InnerRouteDurationFactory IdleFactory { get; set; }

    protected override Humidifier.AppMesh.RouteTypes.TcpTimeout Create()
    {
        var tcpTimeoutResult = CreateTcpTimeout();
        factoryAction?.Invoke(tcpTimeoutResult);

        return tcpTimeoutResult;
    }

    private Humidifier.AppMesh.RouteTypes.TcpTimeout CreateTcpTimeout()
    {
        var tcpTimeoutResult = new Humidifier.AppMesh.RouteTypes.TcpTimeout();

        return tcpTimeoutResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.RouteTypes.TcpTimeout result)
    {
        base.CreateChildren(result);

        result.Idle ??= IdleFactory?.Build();
    }

} // End Of Class

public static class InnerRouteTcpTimeoutFactoryExtensions
{
    public static CombinedResult<InnerRouteTcpTimeoutFactory, InnerRouteDurationFactory> WithIdle(this InnerRouteTcpTimeoutFactory parentFactory, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null)
    {
        parentFactory.IdleFactory = new InnerRouteDurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IdleFactory);
    }

    public static CombinedResult<InnerRouteTcpTimeoutFactory, T1, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<InnerRouteTcpTimeoutFactory, T1> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1>(this CombinedResult<T1, InnerRouteTcpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2>(this CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory, T3, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory, T3> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRouteTcpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<InnerRouteTcpTimeoutFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, InnerRouteTcpTimeoutFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory, T3, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRouteTcpTimeoutFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRouteTcpTimeoutFactory, T4, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRouteTcpTimeoutFactory, T4> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRouteTcpTimeoutFactory, InnerRouteDurationFactory> WithIdle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRouteTcpTimeoutFactory> combinedResult, Action<Humidifier.AppMesh.RouteTypes.Duration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIdle(combinedResult.T5, subFactoryAction));
}
