// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class InnerSiteToSiteVpnAttachmentProposedNetworkFunctionGroupChangeFactory(Action<Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedNetworkFunctionGroupChange> factoryAction = null) : SubResourceFactory<Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedNetworkFunctionGroupChange>
{

    protected override Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedNetworkFunctionGroupChange Create()
    {
        var proposedNetworkFunctionGroupChangeResult = CreateProposedNetworkFunctionGroupChange();
        factoryAction?.Invoke(proposedNetworkFunctionGroupChangeResult);

        return proposedNetworkFunctionGroupChangeResult;
    }

    private Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedNetworkFunctionGroupChange CreateProposedNetworkFunctionGroupChange()
    {
        var proposedNetworkFunctionGroupChangeResult = new Humidifier.NetworkManager.SiteToSiteVpnAttachmentTypes.ProposedNetworkFunctionGroupChange();

        return proposedNetworkFunctionGroupChangeResult;
    }

} // End Of Class

public static class InnerSiteToSiteVpnAttachmentProposedNetworkFunctionGroupChangeFactoryExtensions
{
}
