// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppMesh;

public class InnerVirtualGatewayVirtualGatewayAccessLogFactory(Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog> factoryAction = null) : SubResourceFactory<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog>
{

    internal InnerVirtualGatewayVirtualGatewayFileAccessLogFactory FileFactory { get; set; }

    protected override Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog Create()
    {
        var virtualGatewayAccessLogResult = CreateVirtualGatewayAccessLog();
        factoryAction?.Invoke(virtualGatewayAccessLogResult);

        return virtualGatewayAccessLogResult;
    }

    private Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog CreateVirtualGatewayAccessLog()
    {
        var virtualGatewayAccessLogResult = new Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog();

        return virtualGatewayAccessLogResult;
    }
    public override void CreateChildren(Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayAccessLog result)
    {
        base.CreateChildren(result);

        result.File ??= FileFactory?.Build();
    }

} // End Of Class

public static class InnerVirtualGatewayVirtualGatewayAccessLogFactoryExtensions
{
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile(this InnerVirtualGatewayVirtualGatewayAccessLogFactory parentFactory, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null)
    {
        parentFactory.FileFactory = new InnerVirtualGatewayVirtualGatewayFileAccessLogFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FileFactory);
    }

    public static CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1>(this CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T3, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T3> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<InnerVirtualGatewayVirtualGatewayAccessLogFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2, T3, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T2, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T3, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T3, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T4, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerVirtualGatewayVirtualGatewayAccessLogFactory, T4> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory, InnerVirtualGatewayVirtualGatewayFileAccessLogFactory> WithFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerVirtualGatewayVirtualGatewayAccessLogFactory> combinedResult, Action<Humidifier.AppMesh.VirtualGatewayTypes.VirtualGatewayFileAccessLog> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFile(combinedResult.T5, subFactoryAction));
}
