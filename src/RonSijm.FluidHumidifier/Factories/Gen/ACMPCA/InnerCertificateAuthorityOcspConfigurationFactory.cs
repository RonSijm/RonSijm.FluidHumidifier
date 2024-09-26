// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthorityOcspConfigurationFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration>
{

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration Create()
    {
        var ocspConfigurationResult = CreateOcspConfiguration();
        factoryAction?.Invoke(ocspConfigurationResult);

        return ocspConfigurationResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration CreateOcspConfiguration()
    {
        var ocspConfigurationResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.OcspConfiguration();

        return ocspConfigurationResult;
    }

} // End Of Class

public static class InnerCertificateAuthorityOcspConfigurationFactoryExtensions
{
}
