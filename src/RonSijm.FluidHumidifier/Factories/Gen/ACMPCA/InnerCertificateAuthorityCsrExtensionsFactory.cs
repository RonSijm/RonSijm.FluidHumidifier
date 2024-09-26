// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthorityCsrExtensionsFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions>
{

    internal InnerCertificateAuthorityKeyUsageFactory KeyUsageFactory { get; set; }

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions Create()
    {
        var csrExtensionsResult = CreateCsrExtensions();
        factoryAction?.Invoke(csrExtensionsResult);

        return csrExtensionsResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions CreateCsrExtensions()
    {
        var csrExtensionsResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions();

        return csrExtensionsResult;
    }
    public override void CreateChildren(Humidifier.ACMPCA.CertificateAuthorityTypes.CsrExtensions result)
    {
        base.CreateChildren(result);

        result.KeyUsage ??= KeyUsageFactory?.Build();
    }

} // End Of Class

public static class InnerCertificateAuthorityCsrExtensionsFactoryExtensions
{
    public static CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage(this InnerCertificateAuthorityCsrExtensionsFactory parentFactory, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null)
    {
        parentFactory.KeyUsageFactory = new InnerCertificateAuthorityKeyUsageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsageFactory);
    }

    public static CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2, T3, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2, T3, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory, T3, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateAuthorityCsrExtensionsFactory, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCertificateAuthorityCsrExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2, T3, T4, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<InnerCertificateAuthorityCsrExtensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2, T3, T4, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, InnerCertificateAuthorityCsrExtensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory, T3, T4, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCertificateAuthorityCsrExtensionsFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateAuthorityCsrExtensionsFactory, T4, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCertificateAuthorityCsrExtensionsFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCertificateAuthorityCsrExtensionsFactory, InnerCertificateAuthorityKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCertificateAuthorityCsrExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T5, subFactoryAction));
}
