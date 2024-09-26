// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CertificateManager;

public class CertificateFactory(string resourceName = null, Action<Humidifier.CertificateManager.Certificate> factoryAction = null) : ResourceFactory<Humidifier.CertificateManager.Certificate>(resourceName)
{

    internal List<InnerCertificateDomainValidationOptionFactory> DomainValidationOptionsFactories { get; set; } = [];

    protected override Humidifier.CertificateManager.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.CertificateManager.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.CertificateManager.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }
    public override void CreateChildren(Humidifier.CertificateManager.Certificate result)
    {
        base.CreateChildren(result);

        result.DomainValidationOptions = DomainValidationOptionsFactories.Any() ? DomainValidationOptionsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
    public static CombinedResult<CertificateFactory, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions(this CertificateFactory parentFactory, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null)
    {
        var factory = new InnerCertificateDomainValidationOptionFactory(subFactoryAction);
        parentFactory.DomainValidationOptionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CertificateFactory, T1, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1>(this CombinedResult<CertificateFactory, T1> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1>(this CombinedResult<T1, CertificateFactory> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2>(this CombinedResult<CertificateFactory, T1, T2> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2>(this CombinedResult<T1, CertificateFactory, T2> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2>(this CombinedResult<T1, T2, CertificateFactory> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3>(this CombinedResult<CertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3>(this CombinedResult<T1, CertificateFactory, T2, T3> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, CertificateFactory, T3> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3>(this CombinedResult<T1, T2, T3, CertificateFactory> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, T4, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3, T4>(this CombinedResult<CertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, T4, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, CertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, T4, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, CertificateFactory, T3, T4> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, T4, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CertificateFactory, T4> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CertificateFactory, InnerCertificateDomainValidationOptionFactory> WithDomainValidationOptions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CertificateFactory> combinedResult, Action<Humidifier.CertificateManager.CertificateTypes.DomainValidationOption> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDomainValidationOptions(combinedResult.T5, subFactoryAction));
}
