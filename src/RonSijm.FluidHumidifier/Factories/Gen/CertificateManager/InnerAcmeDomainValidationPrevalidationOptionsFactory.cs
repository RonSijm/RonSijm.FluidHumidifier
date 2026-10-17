// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class InnerAcmeDomainValidationPrevalidationOptionsFactory(Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions> factoryAction = null) : SubResourceFactory<Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions>
{

    internal InnerAcmeDomainValidationDnsPrevalidationOptionsFactory DnsPrevalidationFactory { get; set; }

    protected override Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions Create()
    {
        var prevalidationOptionsResult = CreatePrevalidationOptions();
        factoryAction?.Invoke(prevalidationOptionsResult);

        return prevalidationOptionsResult;
    }

    private Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions CreatePrevalidationOptions()
    {
        var prevalidationOptionsResult = new Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions();

        return prevalidationOptionsResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.AcmeDomainValidationTypes.PrevalidationOptions result)
    {
        base.CreateChildren(result);

        result.DnsPrevalidation ??= DnsPrevalidationFactory?.Build();
    }

} // End Of Class

public static class InnerAcmeDomainValidationPrevalidationOptionsFactoryExtensions
{
    public static CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation(this InnerAcmeDomainValidationPrevalidationOptionsFactory parentFactory, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null)
    {
        parentFactory.DnsPrevalidationFactory = new InnerAcmeDomainValidationDnsPrevalidationOptionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.DnsPrevalidationFactory);
    }

    public static CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1>(this CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1>(this CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2>(this CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2>(this CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2>(this CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3>(this CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3>(this CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory, T3, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3>(this CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory, T3> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2, T3, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3, T4>(this CombinedResult<InnerAcmeDomainValidationPrevalidationOptionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2, T3, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3, T4>(this CombinedResult<T1, InnerAcmeDomainValidationPrevalidationOptionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory, T3, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAcmeDomainValidationPrevalidationOptionsFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory, T4, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAcmeDomainValidationPrevalidationOptionsFactory, T4> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory, InnerAcmeDomainValidationDnsPrevalidationOptionsFactory> WithDnsPrevalidation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAcmeDomainValidationPrevalidationOptionsFactory> combinedResult, Action<Humidifier.CertificateManager.AcmeDomainValidationTypes.DnsPrevalidationOptions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDnsPrevalidation(combinedResult.T5, subFactoryAction).T2);
}
