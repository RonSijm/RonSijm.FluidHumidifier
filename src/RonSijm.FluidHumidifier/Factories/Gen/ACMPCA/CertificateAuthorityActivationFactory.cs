// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class CertificateAuthorityActivationFactory(string resourceName = null, Action<Humidifier.ACMPCA.CertificateAuthorityActivation> factoryAction = null) : ResourceFactory<Humidifier.ACMPCA.CertificateAuthorityActivation>(resourceName)
{

    protected override Humidifier.ACMPCA.CertificateAuthorityActivation Create()
    {
        var certificateAuthorityActivationResult = CreateCertificateAuthorityActivation();
        factoryAction?.Invoke(certificateAuthorityActivationResult);

        return certificateAuthorityActivationResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityActivation CreateCertificateAuthorityActivation()
    {
        var certificateAuthorityActivationResult = new Humidifier.ACMPCA.CertificateAuthorityActivation
        {
            GivenName = InputResourceName,
        };

        return certificateAuthorityActivationResult;
    }

} // End Of Class

public static class CertificateAuthorityActivationFactoryExtensions
{
}
