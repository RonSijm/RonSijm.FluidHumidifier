// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerTransitGatewayRouteTableAttachmentProposedSegmentChangeFactory(Action<Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedSegmentChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedSegmentChange>
{

    protected override Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedSegmentChange Create()
    {
        var proposedSegmentChangeResult = CreateProposedSegmentChange();
        factoryAction?.Invoke(proposedSegmentChangeResult);

        return proposedSegmentChangeResult;
    }

    private Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedSegmentChange CreateProposedSegmentChange()
    {
        var proposedSegmentChangeResult = new Humidifier.NetworkManager.TransitGatewayRouteTableAttachmentTypes.ProposedSegmentChange();

        return proposedSegmentChangeResult;
    }

} // End Of Class

public static class InnerTransitGatewayRouteTableAttachmentProposedSegmentChangeFactoryExtensions
{
}
