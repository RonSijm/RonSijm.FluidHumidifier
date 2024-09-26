// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerVpcAttachmentProposedSegmentChangeFactory(Action<Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange>
{

    protected override Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange Create()
    {
        var proposedSegmentChangeResult = CreateProposedSegmentChange();
        factoryAction?.Invoke(proposedSegmentChangeResult);

        return proposedSegmentChangeResult;
    }

    private Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange CreateProposedSegmentChange()
    {
        var proposedSegmentChangeResult = new Humidifier.NetworkManager.VpcAttachmentTypes.ProposedSegmentChange();

        return proposedSegmentChangeResult;
    }

} // End Of Class

public static class InnerVpcAttachmentProposedSegmentChangeFactoryExtensions
{
}
