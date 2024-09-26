// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeVpcInterfaceAttachmentFactory(Action<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment>
{

    protected override Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment Create()
    {
        var vpcInterfaceAttachmentResult = CreateVpcInterfaceAttachment();
        factoryAction?.Invoke(vpcInterfaceAttachmentResult);

        return vpcInterfaceAttachmentResult;
    }

    private Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment CreateVpcInterfaceAttachment()
    {
        var vpcInterfaceAttachmentResult = new Humidifier.MediaConnect.BridgeTypes.VpcInterfaceAttachment();

        return vpcInterfaceAttachmentResult;
    }

} // End Of Class

public static class InnerBridgeVpcInterfaceAttachmentFactoryExtensions
{
}
