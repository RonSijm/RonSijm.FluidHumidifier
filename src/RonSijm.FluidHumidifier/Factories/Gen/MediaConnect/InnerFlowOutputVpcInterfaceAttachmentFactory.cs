// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowOutputVpcInterfaceAttachmentFactory(Action<Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment>
{

    protected override Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment Create()
    {
        var vpcInterfaceAttachmentResult = CreateVpcInterfaceAttachment();
        factoryAction?.Invoke(vpcInterfaceAttachmentResult);

        return vpcInterfaceAttachmentResult;
    }

    private Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment CreateVpcInterfaceAttachment()
    {
        var vpcInterfaceAttachmentResult = new Humidifier.MediaConnect.FlowOutputTypes.VpcInterfaceAttachment();

        return vpcInterfaceAttachmentResult;
    }

} // End Of Class

public static class InnerFlowOutputVpcInterfaceAttachmentFactoryExtensions
{
}
