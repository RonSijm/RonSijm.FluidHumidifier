// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerDirectConnectGatewayAttachmentProposedSegmentChangeFactory(Action<Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedSegmentChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedSegmentChange>
{

    protected override Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedSegmentChange Create()
    {
        var proposedSegmentChangeResult = CreateProposedSegmentChange();
        factoryAction?.Invoke(proposedSegmentChangeResult);

        return proposedSegmentChangeResult;
    }

    private Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedSegmentChange CreateProposedSegmentChange()
    {
        var proposedSegmentChangeResult = new Humidifier.NetworkManager.DirectConnectGatewayAttachmentTypes.ProposedSegmentChange();

        return proposedSegmentChangeResult;
    }

} // End Of Class

public static class InnerDirectConnectGatewayAttachmentProposedSegmentChangeFactoryExtensions
{
}
