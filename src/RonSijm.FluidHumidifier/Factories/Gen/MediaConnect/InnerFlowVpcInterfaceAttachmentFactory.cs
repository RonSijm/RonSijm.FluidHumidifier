// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowVpcInterfaceAttachmentFactory(Action<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment>
{

    protected override Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment Create()
    {
        var vpcInterfaceAttachmentResult = CreateVpcInterfaceAttachment();
        factoryAction?.Invoke(vpcInterfaceAttachmentResult);

        return vpcInterfaceAttachmentResult;
    }

    private Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment CreateVpcInterfaceAttachment()
    {
        var vpcInterfaceAttachmentResult = new Humidifier.MediaConnect.FlowTypes.VpcInterfaceAttachment();

        return vpcInterfaceAttachmentResult;
    }

} // End Of Class

public static class InnerFlowVpcInterfaceAttachmentFactoryExtensions
{
}
