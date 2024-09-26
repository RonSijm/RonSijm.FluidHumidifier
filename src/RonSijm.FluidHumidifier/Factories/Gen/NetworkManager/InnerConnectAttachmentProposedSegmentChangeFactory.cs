// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerConnectAttachmentProposedSegmentChangeFactory(Action<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange>
{

    protected override Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange Create()
    {
        var proposedSegmentChangeResult = CreateProposedSegmentChange();
        factoryAction?.Invoke(proposedSegmentChangeResult);

        return proposedSegmentChangeResult;
    }

    private Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange CreateProposedSegmentChange()
    {
        var proposedSegmentChangeResult = new Humidifier.NetworkManager.ConnectAttachmentTypes.ProposedSegmentChange();

        return proposedSegmentChangeResult;
    }

} // End Of Class

public static class InnerConnectAttachmentProposedSegmentChangeFactoryExtensions
{
}
