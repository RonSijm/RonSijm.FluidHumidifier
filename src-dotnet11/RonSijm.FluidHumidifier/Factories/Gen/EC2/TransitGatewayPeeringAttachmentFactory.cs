// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayPeeringAttachmentFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayPeeringAttachment> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayPeeringAttachment>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayPeeringAttachment Create()
    {
        var transitGatewayPeeringAttachmentResult = CreateTransitGatewayPeeringAttachment();
        factoryAction?.Invoke(transitGatewayPeeringAttachmentResult);

        return transitGatewayPeeringAttachmentResult;
    }

    private Humidifier.EC2.TransitGatewayPeeringAttachment CreateTransitGatewayPeeringAttachment()
    {
        var transitGatewayPeeringAttachmentResult = new Humidifier.EC2.TransitGatewayPeeringAttachment
        {
            GivenName = InputResourceName,
        };

        return transitGatewayPeeringAttachmentResult;
    }

} // End Of Class

public static class TransitGatewayPeeringAttachmentFactoryExtensions
{
}
