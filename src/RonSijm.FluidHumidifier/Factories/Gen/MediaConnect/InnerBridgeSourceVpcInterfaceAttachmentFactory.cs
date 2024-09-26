// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerBridgeSourceVpcInterfaceAttachmentFactory(Action<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment>
{

    protected override Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment Create()
    {
        var vpcInterfaceAttachmentResult = CreateVpcInterfaceAttachment();
        factoryAction?.Invoke(vpcInterfaceAttachmentResult);

        return vpcInterfaceAttachmentResult;
    }

    private Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment CreateVpcInterfaceAttachment()
    {
        var vpcInterfaceAttachmentResult = new Humidifier.MediaConnect.BridgeSourceTypes.VpcInterfaceAttachment();

        return vpcInterfaceAttachmentResult;
    }

} // End Of Class

public static class InnerBridgeSourceVpcInterfaceAttachmentFactoryExtensions
{
}
