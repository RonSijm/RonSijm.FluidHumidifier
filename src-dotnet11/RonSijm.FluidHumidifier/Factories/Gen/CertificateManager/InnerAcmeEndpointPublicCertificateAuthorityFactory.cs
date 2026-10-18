// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeEndpointPublicCertificateAuthorityFactory(Action<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority>
{

    protected override Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority Create()
    {
        var publicCertificateAuthorityResult = CreatePublicCertificateAuthority();
        factoryAction?.Invoke(publicCertificateAuthorityResult);

        return publicCertificateAuthorityResult;
    }

    private Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority CreatePublicCertificateAuthority()
    {
        var publicCertificateAuthorityResult = new Humidifier.CertificateManager.AcmeEndpointTypes.PublicCertificateAuthority();

        return publicCertificateAuthorityResult;
    }

} // End Of Class

public static class InnerAcmeEndpointPublicCertificateAuthorityFactoryExtensions
{
}
