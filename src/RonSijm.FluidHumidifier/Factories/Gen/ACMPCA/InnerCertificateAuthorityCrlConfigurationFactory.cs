// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateAuthorityCrlConfigurationFactory(Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration>
{

    internal InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory CrlDistributionPointExtensionConfigurationFactory { get; set; }

    protected override Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration Create()
    {
        var crlConfigurationResult = CreateCrlConfiguration();
        factoryAction?.Invoke(crlConfigurationResult);

        return crlConfigurationResult;
    }

    private Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration CreateCrlConfiguration()
    {
        var crlConfigurationResult = new Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration();

        return crlConfigurationResult;
    }
    public override void CreateChildren(Humidifier.ACMPCA.CertificateAuthorityTypes.CrlConfiguration result)
    {
        base.CreateChildren(result);

        result.CrlDistributionPointExtensionConfiguration ??= CrlDistributionPointExtensionConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerCertificateAuthorityCrlConfigurationFactoryExtensions
{
    public static CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration(this InnerCertificateAuthorityCrlConfigurationFactory parentFactory, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null)
    {
        parentFactory.CrlDistributionPointExtensionConfigurationFactory = new InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CrlDistributionPointExtensionConfigurationFactory);
    }

    public static CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1>(this CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1>(this CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2>(this CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2>(this CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2, T3, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3>(this CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2, T3, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory, T3, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateAuthorityCrlConfigurationFactory, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCertificateAuthorityCrlConfigurationFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2, T3, T4, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerCertificateAuthorityCrlConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2, T3, T4, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerCertificateAuthorityCrlConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory, T3, T4, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCertificateAuthorityCrlConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateAuthorityCrlConfigurationFactory, T4, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCertificateAuthorityCrlConfigurationFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCertificateAuthorityCrlConfigurationFactory, InnerCertificateAuthorityCrlDistributionPointExtensionConfigurationFactory> WithCrlDistributionPointExtensionConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCertificateAuthorityCrlConfigurationFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateAuthorityTypes.CrlDistributionPointExtensionConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCrlDistributionPointExtensionConfiguration(combinedResult.T5, subFactoryAction));
}
