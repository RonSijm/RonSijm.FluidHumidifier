// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualNodeAccessLogFactory(Action<Humidifier.AppMesh.VirtualNodeTypes.AccessLog> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualNodeTypes.AccessLog>
{

    internal InnerVirtualNodeFileAccessLogFactory FileFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualNodeTypes.AccessLog Create()
    {
        var accessLogResult = CreateAccessLog();
        factoryAction?.Invoke(accessLogResult);

        return accessLogResult;
    }

    private Humidifier.AppMesh.VirtualNodeTypes.AccessLog CreateAccessLog()
    {
        var accessLogResult = new Humidifier.AppMesh.VirtualNodeTypes.AccessLog();

        return accessLogResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualNodeTypes.AccessLog result)
    {
        base.CreateChildren(result);

        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualNodeAccessLogFactoryExtensions
{
    public static CombinedResult<InnerVirtualNodeAccessLogFactory, InnerVirtualNodeFileAccessLogFactory> WithFile(this InnerVirtualNodeAccessLogFactory parentFactory, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerVirtualNodeFileAccessLogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerVirtualNodeAccessLogFactory, T1, InnerVirtualNodeFileAccessLogFactory> WithFile<T1>(this CombinedResult<InnerVirtualNodeAccessLogFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeAccessLogFactory, InnerVirtualNodeFileAccessLogFactory> WithFile<T1>(this CombinedResult<T1, InnerVirtualNodeAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2, T3, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2, T3, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory, T3, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeAccessLogFactory, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualNodeAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2, T3, T4, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerVirtualNodeAccessLogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2, T3, T4, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualNodeAccessLogFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory, T3, T4, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualNodeAccessLogFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualNodeAccessLogFactory, T4, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualNodeAccessLogFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualNodeAccessLogFactory, InnerVirtualNodeFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualNodeAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualNodeTypes.FileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
