// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourceGatewayBridgeSourceFactory(Action<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource>
{

    internal InnerFlowSourceVpcInterfaceAttachmentFactory VpcInterfaceAttachmentFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource Create()
    {
        var gatewayBridgeSourceResult = CreateGatewayBridgeSource();
        factoryAction?.Invoke(gatewayBridgeSourceResult);

        return gatewayBridgeSourceResult;
    }

    private Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource CreateGatewayBridgeSource()
    {
        var gatewayBridgeSourceResult = new Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource();

        return gatewayBridgeSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowSourceTypes.GatewayBridgeSource result)
    {
        base.CreateChildren(result);

        result.VpcInterfaceAttachment ??= VpcInterfaceAttachmentFactory?.Build();
    }

} // End Of Class

public static class InnerFlowSourceGatewayBridgeSourceFactoryExtensions
{
    public static CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment(this InnerFlowSourceGatewayBridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null)
    {
        parentFactory.VpcInterfaceAttachmentFactory = new InnerFlowSourceVpcInterfaceAttachmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcInterfaceAttachmentFactory);
    }

    public static CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1>(this CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1>(this CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2, T3, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2, T3, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory, T3, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2, T3, T4, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<InnerFlowSourceGatewayBridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2, T3, T4, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowSourceGatewayBridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory, T3, T4, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowSourceGatewayBridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory, T4, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowSourceGatewayBridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowSourceGatewayBridgeSourceFactory, InnerFlowSourceVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowSourceGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T5, subFactoryAction));
}
