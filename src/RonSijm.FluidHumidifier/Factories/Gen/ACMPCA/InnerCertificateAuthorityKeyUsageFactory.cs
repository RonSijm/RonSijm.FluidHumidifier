// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthorityKeyUsageFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage>
{

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage Create()
    {
        var keyUsageResult = CreateKeyUsage();
        factoryAction?.Invoke(keyUsageResult);

        return keyUsageResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage CreateKeyUsage()
    {
        var keyUsageResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage();

        return keyUsageResult;
    }

} // End Of Class

public static class InnerCertificateAuthorityKeyUsageFactoryExtensions
{
}
