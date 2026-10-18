// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantCertificateFactory(Action<Humidifier.CloudFront.DistributionTenantTypes.Certificate> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTenantTypes.Certificate>
{

    protected override Humidifier.CloudFront.DistributionTenantTypes.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.CloudFront.DistributionTenantTypes.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.CloudFront.DistributionTenantTypes.Certificate();

        return certificateResult;
    }

} // End Of Class

public static class InnerDistributionTenantCertificateFactoryExtensions
{
}
