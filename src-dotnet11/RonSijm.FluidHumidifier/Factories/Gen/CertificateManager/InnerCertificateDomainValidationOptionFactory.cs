// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerCertificateDomainValidationOptionFactory(Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption>
{

    protected override Humidifier.CertificateManager.CertificateTypes.DomainValidationOption Create()
    {
        var domainValidationOptionResult = CreateDomainValidationOption();
        factoryAction?.Invoke(domainValidationOptionResult);

        return domainValidationOptionResult;
    }

    private Humidifier.CertificateManager.CertificateTypes.DomainValidationOption CreateDomainValidationOption()
    {
        var domainValidationOptionResult = new Humidifier.CertificateManager.CertificateTypes.DomainValidationOption();

        return domainValidationOptionResult;
    }

} // End Of Class

public static class InnerCertificateDomainValidationOptionFactoryExtensions
{
}
