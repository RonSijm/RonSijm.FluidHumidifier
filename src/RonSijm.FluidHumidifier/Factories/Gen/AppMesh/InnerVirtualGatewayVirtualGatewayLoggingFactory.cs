// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayLoggingFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging>
{

    internal InnerVirtualGatewayVirtualGatewayAccessLogFactory AccessLogFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging Create()
    {
        var virtualGatewayLoggingResult = CreateVirtualGatewayLogging();
        factoryAction?.Invoke(virtualGatewayLoggingResult);

        return virtualGatewayLoggingResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging CreateVirtualGatewayLogging()
    {
        var virtualGatewayLoggingResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging();

        return virtualGatewayLoggingResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayLogging result)
    {
        base.CreateChildren(result);

        result.AccessLog ??= AccessLogFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayLoggingFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog(this InnerVirtualGatewayVirtualGatewayLoggingFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null)
    {
        parentFactory.AccessLogFactory = new InnerVirtualGatewayVirtualGatewayAccessLogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessLogFactory);
    }

    public static CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1>(this CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayLoggingFactory, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewayVirtualGatewayLoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2, T3, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayLoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory, T3, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayLoggingFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayLoggingFactory, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayLoggingFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayLoggingFactory, InnerVirtualGatewayVirtualGatewayAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T5, subFactoryAction));
}
