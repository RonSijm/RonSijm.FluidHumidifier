// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionViewerCertificateFactory(Action<Humidifier.CloudFront.DistributionTypes.ViewerCertificate> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTypes.ViewerCertificate>
{

    protected override Humidifier.CloudFront.DistributionTypes.ViewerCertificate Create()
    {
        var viewerCertificateResult = CreateViewerCertificate();
        factoryAction?.Invoke(viewerCertificateResult);

        return viewerCertificateResult;
    }

    private Humidifier.CloudFront.DistributionTypes.ViewerCertificate CreateViewerCertificate()
    {
        var viewerCertificateResult = new Humidifier.CloudFront.DistributionTypes.ViewerCertificate();

        return viewerCertificateResult;
    }

} // End Of Class

public static class InnerDistributionViewerCertificateFactoryExtensions
{
}
