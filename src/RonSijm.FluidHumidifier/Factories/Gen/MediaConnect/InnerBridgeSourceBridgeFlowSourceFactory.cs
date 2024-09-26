// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourceBridgeFlowSourceFactory(Action<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource>
{

    internal InnerBridgeSourceVpcInterfaceAttachmentFactory FlowVpcInterfaceAttachmentFactory { get; set; }

    protected override Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource Create()
    {
        var bridgeFlowSourceResult = CreateBridgeFlowSource();
        factoryAction?.Invoke(bridgeFlowSourceResult);

        return bridgeFlowSourceResult;
    }

    private Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource CreateBridgeFlowSource()
    {
        var bridgeFlowSourceResult = new Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource();

        return bridgeFlowSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.BridgeSourceTypes.BridgeFlowSource result)
    {
        base.CreateChildren(result);

        result.FlowVpcInterfaceAttachment ??= FlowVpcInterfaceAttachmentFactory?.Build();
    }

} // End Of Class

public static class InnerBridgeSourceBridgeFlowSourceFactoryExtensions
{
    public static CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment(this InnerBridgeSourceBridgeFlowSourceFactory parentFactory, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null)
    {
        parentFactory.FlowVpcInterfaceAttachmentFactory = new InnerBridgeSourceVpcInterfaceAttachmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FlowVpcInterfaceAttachmentFactory);
    }

    public static CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1>(this CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1>(this CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2, T3, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2, T3, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory, T3, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2, T3, T4, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<InnerBridgeSourceBridgeFlowSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2, T3, T4, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, InnerBridgeSourceBridgeFlowSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory, T3, T4, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBridgeSourceBridgeFlowSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory, T4, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBridgeSourceBridgeFlowSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBridgeSourceBridgeFlowSourceFactory, InnerBridgeSourceVpcInterfaceAttachmentFactory> WithFlowVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBridgeSourceBridgeFlowSourceFactory> combinedResult, Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFlowVpcInterfaceAttachment(combinedResult.T5, subFactoryAction));
}
