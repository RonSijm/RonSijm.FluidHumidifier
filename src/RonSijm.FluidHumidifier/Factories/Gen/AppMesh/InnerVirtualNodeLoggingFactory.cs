// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeLoggingFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.Logging> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.Logging>
{

    internal InnerVirtualNodeAccessLogFactory AccessLogFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.Logging Create()
    {
        var loggingResult = CreateLogging();
        factoryAction?.Invoke(loggingResult);

        return loggingResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.Logging CreateLogging()
    {
        var loggingResult = new Humidifier.AppMesh.VirtualNodeTypes.Logging();

        return loggingResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.Logging result)
    {
        base.CreateChildren(result);

        result.AccessLog ??= AccessLogFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeLoggingFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeLoggingFactory, InnerVirtualNodeAccessLogFactory> WithAccessLog(this InnerVirtualNodeLoggingFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null)
    {
        parentFactory.AccessLogFactory = new InnerVirtualNodeAccessLogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AccessLogFactory);
    }

    public static CombinedResult<InnerVirtualNodeLoggingFactory, T1, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1>(this CombinedResult<InnerVirtualNodeLoggingFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeLoggingFactory, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1>(this CombinedResult<T1, InnerVirtualNodeLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2, T3, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2, T3, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory, T3, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeLoggingFactory, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2, T3, T4, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeLoggingFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2, T3, T4, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeLoggingFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory, T3, T4, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeLoggingFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeLoggingFactory, T4, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeLoggingFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeLoggingFactory, InnerVirtualNodeAccessLogFactory> WithAccessLog<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeLoggingFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAccessLog(combinedResult.T5, subFactoryAction));
}
