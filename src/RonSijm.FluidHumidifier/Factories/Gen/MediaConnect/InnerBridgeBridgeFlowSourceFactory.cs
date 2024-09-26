// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeBridgeFlowSourceFactory(Action<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource>
{

    internal InnerBridgeVpcInterfaceAttachmentFactory FlowVpcInterfaceAttachmentFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource Create()
    {
        var bridgeFlowSourceResult = CreateBridgeFlowSource();
        factoryAction?.Invoke(bridgeFlowSourceResult);

        return bridgeFlowSourceResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource CreateBridgeFlowSource()
    {
        var bridgeFlowSourceResult = new Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource();

        return bridgeFlowSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeTypes.BridgeFlowSource result)
    {
        base.CreateChildren(result);

        result.FlowVpcInterfaceAttachment ??= FlowVpcInterfaceAttachmentFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeBridgeFlowSourceFactoryExtensions
{
    public static CombinedResult<InnerBridgeBridgeFlowSourceFactory, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment(this InnerBridgeBridgeFlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null)
    {
        parentFactory.FlowVpcInterfaceAttachmentFactory = new InnerBridgeVpcInterfaceAttachmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowVpcInterfaceAttachmentFactory);
    }

    public static CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1>(this CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1>(this CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2, T3, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2, T3, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory, T3, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeFlowSourceFactory, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2, T3, T4, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<InnerBridgeBridgeFlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2, T3, T4, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeBridgeFlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory, T3, T4, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeBridgeFlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeBridgeFlowSourceFactory, T4, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeBridgeFlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeFlowSourceFactory, InnerBridgeVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T5, subFactoryAction));
}
