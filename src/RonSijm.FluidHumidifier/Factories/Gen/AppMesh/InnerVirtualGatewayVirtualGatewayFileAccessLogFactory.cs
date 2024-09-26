// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayFileAccessLogFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog>
{

    internal InnerVirtualGatewayLoggingFormatFactory FormatFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog Create()
    {
        var virtualGatewayFileAccessLogResult = CreateVirtualGatewayFileAccessLog();
        factoryAction?.Invoke(virtualGatewayFileAccessLogResult);

        return virtualGatewayFileAccessLogResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog CreateVirtualGatewayFileAccessLog()
    {
        var virtualGatewayFileAccessLogResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog();

        return virtualGatewayFileAccessLogResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog result)
    {
        base.CreateChildren(result);

        result.Format ??= FormatFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayFileAccessLogFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, InnerVirtualGatewayLoggingFormatFactory> WithFormat(this InnerVirtualGatewayVirtualGatewayFileAccessLogFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null)
    {
        parentFactory.FormatFactory = new InnerVirtualGatewayLoggingFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatFactory);
    }

    public static CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1>(this CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2, T3, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2, T3, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T3, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2, T3, T4, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2, T3, T4, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T3, T4, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T4, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory, InnerVirtualGatewayLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T5, subFactoryAction));
}
