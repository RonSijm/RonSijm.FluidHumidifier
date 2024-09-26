// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateKeyUsageFactory(Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateTypes.KeyUsage>
{

    protected override Humidifier.ACMPCA.CertificateTypes.KeyUsage Create()
    {
        var keyUsageResult = CreateKeyUsage();
        factoryAction?.Invoke(keyUsageResult);

        return keyUsageResult;
    }

    private Humidifier.ACMPCA.CertificateTypes.KeyUsage CreateKeyUsage()
    {
        var keyUsageResult = new Humidifier.ACMPCA.CertificateTypes.KeyUsage();

        return keyUsageResult;
    }

} // End Of Class

public static class InnerCertificateKeyUsageFactoryExtensions
{
}
