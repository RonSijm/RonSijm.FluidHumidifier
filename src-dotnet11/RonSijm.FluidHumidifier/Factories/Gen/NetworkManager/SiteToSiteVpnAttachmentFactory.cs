// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkManager;

public class SiteToSiteVpnAttachmentFactory(string resourceName = null, Action<Humidifier.NetworkManager.SiteToSiteVpnAttachment> factoryAction = null) : ResourceFactory<Humidifier.NetworkManager.SiteToSiteVpnAttachment>(resourceName)
{

    protected override Humidifier.NetworkManager.SiteToSiteVpnAttachment Create()
    {
        var siteToSiteVpnAttachmentResult = CreateSiteToSiteVpnAttachment();
        factoryAction?.Invoke(siteToSiteVpnAttachmentResult);

        return siteToSiteVpnAttachmentResult;
    }

    private Humidifier.NetworkManager.SiteToSiteVpnAttachment CreateSiteToSiteVpnAttachment()
    {
        var siteToSiteVpnAttachmentResult = new Humidifier.NetworkManager.SiteToSiteVpnAttachment
        {
            GivenName = InputResourceName,
        };

        return siteToSiteVpnAttachmentResult;
    }

} // End Of Class

public static class SiteToSiteVpnAttachmentFactoryExtensions
{
}
