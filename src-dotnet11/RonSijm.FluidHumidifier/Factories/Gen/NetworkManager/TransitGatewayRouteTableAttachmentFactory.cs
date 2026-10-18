// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class TransitGatewayRouteTableAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.TransitGatewayRouteTableAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.TransitGatewayRouteTableAttachment>(resourceName)
{

    protected override Humidifier.NetworkManager.TransitGatewayRouteTableAttachment Create()
    {
        var transitGatewayRouteTableAttachmentResult = CreateTransitGatewayRouteTableAttachment();
        factoryAction?.Invoke(transitGatewayRouteTableAttachmentResult);

        return transitGatewayRouteTableAttachmentResult;
    }

    private Humidifier.NetworkManager.TransitGatewayRouteTableAttachment CreateTransitGatewayRouteTableAttachment()
    {
        var transitGatewayRouteTableAttachmentResult = new Humidifier.NetworkManager.TransitGatewayRouteTableAttachment
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteTableAttachmentResult;
    }

} // End Of Class

public static class TransitGatewayRouteTableAttachmentFactoryExtensions
{
}
