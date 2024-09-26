// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeFileAccessLogFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog>
{

    internal InnerVirtualNodeLoggingFormatFactory FormatFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog Create()
    {
        var fileAccessLogResult = CreateFileAccessLog();
        factoryAction?.Invoke(fileAccessLogResult);

        return fileAccessLogResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog CreateFileAccessLog()
    {
        var fileAccessLogResult = new Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog();

        return fileAccessLogResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog result)
    {
        base.CreateChildren(result);

        result.Format ??= FormatFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeFileAccessLogFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeFileAccessLogFactory, InnerVirtualNodeLoggingFormatFactory> WithFormat(this InnerVirtualNodeFileAccessLogFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null)
    {
        parentFactory.FormatFactory = new InnerVirtualNodeLoggingFormatFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FormatFactory);
    }

    public static CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1>(this CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1>(this CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2, T3, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2, T3, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory, T3, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeFileAccessLogFactory, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2, T3, T4, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeFileAccessLogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2, T3, T4, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeFileAccessLogFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory, T3, T4, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeFileAccessLogFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeFileAccessLogFactory, T4, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeFileAccessLogFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeFileAccessLogFactory, InnerVirtualNodeLoggingFormatFactory> WithFormat<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeFileAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.LoggingFormat> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFormat(combinedResult.T5, subFactoryAction));
}
