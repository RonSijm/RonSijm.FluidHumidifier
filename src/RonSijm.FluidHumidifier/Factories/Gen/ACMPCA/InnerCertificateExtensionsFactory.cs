// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateExtensionsFactory(Action<Humidifier.ACMPCA.CertificateTypes.Extensions> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateTypes.Extensions>
{

    internal InnerCertificateKeyUsageFactory KeyUsageFactory { get; set; }

    protected override Humidifier.ACMPCA.CertificateTypes.Extensions Create()
    {
        var extensionsResult = CreateExtensions();
        factoryAction?.Invoke(extensionsResult);

        return extensionsResult;
    }

    private Humidifier.ACMPCA.CertificateTypes.Extensions CreateExtensions()
    {
        var extensionsResult = new Humidifier.ACMPCA.CertificateTypes.Extensions();

        return extensionsResult;
    }
    public override void CreateChildren(Humidifier.ACMPCA.CertificateTypes.Extensions result)
    {
        base.CreateChildren(result);

        result.KeyUsage ??= KeyUsageFactory?.Build();
    }

} // End Of Class

public static class InnerCertificateExtensionsFactoryExtensions
{
    public static CombinedResult<InnerCertificateExtensionsFactory, InnerCertificateKeyUsageFactory> WithKeyUsage(this InnerCertificateExtensionsFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null)
    {
        parentFactory.KeyUsageFactory = new InnerCertificateKeyUsageFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyUsageFactory);
    }

    public static CombinedResult<InnerCertificateExtensionsFactory, T1, InnerCertificateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<InnerCertificateExtensionsFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateExtensionsFactory, InnerCertificateKeyUsageFactory> WithKeyUsage<T1>(this CombinedResult<T1, InnerCertificateExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCertificateExtensionsFactory, T1, T2, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<InnerCertificateExtensionsFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateExtensionsFactory, T2, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, InnerCertificateExtensionsFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateExtensionsFactory, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2>(this CombinedResult<T1, T2, InnerCertificateExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCertificateExtensionsFactory, T1, T2, T3, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<InnerCertificateExtensionsFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateExtensionsFactory, T2, T3, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, InnerCertificateExtensionsFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateExtensionsFactory, T3, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, InnerCertificateExtensionsFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateExtensionsFactory, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCertificateExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCertificateExtensionsFactory, T1, T2, T3, T4, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<InnerCertificateExtensionsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateExtensionsFactory, T2, T3, T4, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, InnerCertificateExtensionsFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateExtensionsFactory, T3, T4, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCertificateExtensionsFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateExtensionsFactory, T4, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCertificateExtensionsFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCertificateExtensionsFactory, InnerCertificateKeyUsageFactory> WithKeyUsage<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCertificateExtensionsFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.KeyUsage> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyUsage(combinedResult.T5, subFactoryAction));
}
