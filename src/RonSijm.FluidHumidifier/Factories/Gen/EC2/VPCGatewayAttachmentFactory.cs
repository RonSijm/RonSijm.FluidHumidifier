// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class VPCGatewayAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.VPCGatewayAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.VPCGatewayAttachment>(resourceName)
{

    protected override Humidifier.EC2.VPCGatewayAttachment Create()
    {
        var vPCGatewayAttachmentResult = CreateVPCGatewayAttachment();
        factoryAction?.Invoke(vPCGatewayAttachmentResult);

        return vPCGatewayAttachmentResult;
    }

    private Humidifier.EC2.VPCGatewayAttachment CreateVPCGatewayAttachment()
    {
        var vPCGatewayAttachmentResult = new Humidifier.EC2.VPCGatewayAttachment
        {
            GivenName = InputResourceName,
        };

        return vPCGatewayAttachmentResult;
    }

} // End Of Class

public static class VPCGatewayAttachmentFactoryExtensions
{
}
