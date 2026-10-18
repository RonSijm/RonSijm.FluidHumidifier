// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EKS;

public class CertificateAuthorityFactory(string resourceName = null, Action<Humidifier.EKS.CertificateAuthority> factoryAction = null) : ResourceFactory<Humidifier.EKS.CertificateAuthority>(resourceName)
{

    protected override Humidifier.EKS.CertificateAuthority Create()
    {
        var certificateAuthorityResult = CreateCertificateAuthority();
        factoryAction?.Invoke(certificateAuthorityResult);

        return certificateAuthorityResult;
    }

    private Humidifier.EKS.CertificateAuthority CreateCertificateAuthority()
    {
        var certificateAuthorityResult = new Humidifier.EKS.CertificateAuthority
        {
            GivenName = InputResourceName,
        };

        return certificateAuthorityResult;
    }

} // End Of Class

public static class CertificateAuthorityFactoryExtensions
{
}
