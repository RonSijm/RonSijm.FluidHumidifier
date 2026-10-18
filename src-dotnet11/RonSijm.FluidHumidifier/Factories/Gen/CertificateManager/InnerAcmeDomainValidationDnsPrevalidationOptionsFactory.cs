// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeDomainValidationDnsPrevalidationOptionsFactory(Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions>
{

    internal InnerAcmeDomainValidationDomainScopeFactory DomainScopeFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions Create()
    {
        var dnsPrevalidationOptionsResult = CreateDnsPrevalidationOptions();
        factoryAction?.Invoke(dnsPrevalidationOptionsResult);

        return dnsPrevalidationOptionsResult;
    }

    private Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions CreateDnsPrevalidationOptions()
    {
        var dnsPrevalidationOptionsResult = new Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions();

        return dnsPrevalidationOptionsResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions result)
    {
        base.CreateChildren(result);

        result.DomainScope ??= DomainScopeFactory?.Build();
    }

} // End Of Class

public static class InnerAcmeDomainValidationDnsPrevalidationOptionsFactoryExtensions
{
    public static CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope(this InnerAcmeDomainValidationDnsPrevalidationOptionsFactory parentFactory, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null)
    {
        parentFactory.DomainScopeFactory = new InnerAcmeDomainValidationDomainScopeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DomainScopeFactory);
    }

    public static CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1>(this CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1>(this CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2>(this CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2>(this CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2>(this CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2, T3, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3>(this CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2, T3, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3>(this CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T3, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3>(this CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2, T3, T4, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3, T4>(this CombinedResult<InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2, T3, T4, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3, T4>(this CombinedResult<T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T3, T4, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T4, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory, InnerAcmeDomainValidationDomainScopeFactory> WithDomainScope<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DomainScope> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainScope(combinedResult.T5, subFactoryAction).T2);
}
