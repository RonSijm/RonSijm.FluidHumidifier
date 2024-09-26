// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration>
{

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration Create()
    {
        var crlDistributionPointExtensionConfigurationResult = CreateCrlDistributionPointExtensionConfiguration();
        factoryAction?.Invoke(crlDistributionPointExtensionConfigurationResult);

        return crlDistributionPointExtensionConfigurationResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration CreateCrlDistributionPointExtensionConfiguration()
    {
        var crlDistributionPointExtensionConfigurationResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration();

        return crlDistributionPointExtensionConfigurationResult;
    }

} // End Of Class

public static class InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactoryExtensions
{
}
