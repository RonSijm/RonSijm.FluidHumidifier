// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerDistributionTenantManagedCertificateRequestFactory(Action<Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest>
{

    protected override Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest Create()
    {
        var managedCertificateRequestResult = CreateManagedCertificateRequest();
        factoryAction?.Invoke(managedCertificateRequestResult);

        return managedCertificateRequestResult;
    }

    private Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest CreateManagedCertificateRequest()
    {
        var managedCertificateRequestResult = new Humidifier.CloudFront.DistributionTenantTypes.ManagedCertificateRequest();

        return managedCertificateRequestResult;
    }

} // End Of Class

public static class InnerDistributionTenantManagedCertificateRequestFactoryExtensions
{
}
