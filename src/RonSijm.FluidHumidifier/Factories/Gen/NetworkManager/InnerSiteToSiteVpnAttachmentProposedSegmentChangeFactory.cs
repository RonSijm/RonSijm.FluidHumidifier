// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerSiteToSiteVpnAttachmentProposedSegmentChangeFactory(Action<Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedSegmentChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedSegmentChange>
{

    protected override Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedSegmentChange Create()
    {
        var proposedSegmentChangeResult = CreateProposedSegmentChange();
        factoryAction?.Invoke(proposedSegmentChangeResult);

        return proposedSegmentChangeResult;
    }

    private Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedSegmentChange CreateProposedSegmentChange()
    {
        var proposedSegmentChangeResult = new Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedSegmentChange();

        return proposedSegmentChangeResult;
    }

} // End Of Class

public static class InnerSiteToSiteVpnAttachmentProposedSegmentChangeFactoryExtensions
{
}
