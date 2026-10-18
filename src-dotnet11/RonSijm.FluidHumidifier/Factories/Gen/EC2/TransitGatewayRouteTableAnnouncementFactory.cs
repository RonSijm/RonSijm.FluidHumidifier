// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class TransitGatewayRouteTableAnnouncementFactory(string resourceName = null, Action<Humidifier.EC2.TransitGatewayRouteTableAnnouncement> factoryAction = null) : ResourceFactory<Humidifier.EC2.TransitGatewayRouteTableAnnouncement>(resourceName)
{

    protected override Humidifier.EC2.TransitGatewayRouteTableAnnouncement Create()
    {
        var transitGatewayRouteTableAnnouncementResult = CreateTransitGatewayRouteTableAnnouncement();
        factoryAction?.Invoke(transitGatewayRouteTableAnnouncementResult);

        return transitGatewayRouteTableAnnouncementResult;
    }

    private Humidifier.EC2.TransitGatewayRouteTableAnnouncement CreateTransitGatewayRouteTableAnnouncement()
    {
        var transitGatewayRouteTableAnnouncementResult = new Humidifier.EC2.TransitGatewayRouteTableAnnouncement
        {
            GivenName = InputResourceName,
        };

        return transitGatewayRouteTableAnnouncementResult;
    }

} // End Of Class

public static class TransitGatewayRouteTableAnnouncementFactoryExtensions
{
}
