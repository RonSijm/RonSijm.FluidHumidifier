// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerFlowSourceVpcInterfaceAttachmentFactory(Action<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment>
{

    protected override Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment Create()
    {
        var vpcInterfaceAttachmentResult = CreateVpcInterfaceAttachment();
        factoryAction?.Invoke(vpcInterfaceAttachmentResult);

        return vpcInterfaceAttachmentResult;
    }

    private Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment CreateVpcInterfaceAttachment()
    {
        var vpcInterfaceAttachmentResult = new Humidifier.MediaConnect.FlowSourceTypes.VpcInterfaceAttachment();

        return vpcInterfaceAttachmentResult;
    }

} // End Of Class

public static class InnerFlowSourceVpcInterfaceAttachmentFactoryExtensions
{
}
