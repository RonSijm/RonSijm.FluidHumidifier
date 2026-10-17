// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudFront;

public class InnerTrustStoreCaCertificatesBundleS3LocationFactory(Action<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location> factoryAction = null) : SubResourceFactory<Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location>
{

    protected override Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location Create()
    {
        var caCertificatesBundleS3LocationResult = CreateCaCertificatesBundleS3Location();
        factoryAction?.Invoke(caCertificatesBundleS3LocationResult);

        return caCertificatesBundleS3LocationResult;
    }

    private Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location CreateCaCertificatesBundleS3Location()
    {
        var caCertificatesBundleS3LocationResult = new Humidifier.CloudFront.TrustStoreTypes.CaCertificatesBundleS3Location();

        return caCertificatesBundleS3LocationResult;
    }

} // End Of Class

public static class InnerTrustStoreCaCertificatesBundleS3LocationFactoryExtensions
{
}
