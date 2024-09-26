// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowGatewayBridgeSourceFactory(Action<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource>
{

    internal InnerFlowVpcInterfaceAttachmentFactory VpcInterfaceAttachmentFactory { get; set; }

    protected override Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource Create()
    {
        var gatewayBridgeSourceResult = CreateGatewayBridgeSource();
        factoryAction?.Invoke(gatewayBridgeSourceResult);

        return gatewayBridgeSourceResult;
    }

    private Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource CreateGatewayBridgeSource()
    {
        var gatewayBridgeSourceResult = new Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource();

        return gatewayBridgeSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaConnect.FlowTypes.GatewayBridgeSource result)
    {
        base.CreateChildren(result);

        result.VpcInterfaceAttachment ??= VpcInterfaceAttachmentFactory?.Build();
    }

} // End Of Class

public static class InnerFlowGatewayBridgeSourceFactoryExtensions
{
    public static CombinedResult<InnerFlowGatewayBridgeSourceFactory, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment(this InnerFlowGatewayBridgeSourceFactory parentFactory, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null)
    {
        parentFactory.VpcInterfaceAttachmentFactory = new InnerFlowVpcInterfaceAttachmentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VpcInterfaceAttachmentFactory);
    }

    public static CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1>(this CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1>(this CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2>(this CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2, T3, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2, T3, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory, T3, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory, T3> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowGatewayBridgeSourceFactory, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerFlowGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2, T3, T4, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<InnerFlowGatewayBridgeSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2, T3, T4, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, InnerFlowGatewayBridgeSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory, T3, T4, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerFlowGatewayBridgeSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerFlowGatewayBridgeSourceFactory, T4, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerFlowGatewayBridgeSourceFactory, T4> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerFlowGatewayBridgeSourceFactory, InnerFlowVpcInterfaceAttachmentFactory> WithVpcInterfaceAttachment<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerFlowGatewayBridgeSourceFactory> combinedResult, Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVpcInterfaceAttachment(combinedResult.T5, subFactoryAction));
}
