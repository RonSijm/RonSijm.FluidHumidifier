// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeDomainValidationDomainScopeFactory(Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope>
{

    protected override Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope Create()
    {
        var domainScopeResult = CreateDomainScope();
        factoryAction?.Invoke(domainScopeResult);

        return domainScopeResult;
    }

    private Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope CreateDomainScope()
    {
        var domainScopeResult = new Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope();

        return domainScopeResult;
    }

} // End Of Class

public static class InnerAcmeDomainValidationDomainScopeFactoryExtensions
{
}
