// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class CertificateFactory(string resourceName = null, Action<Humidifier.ACMPCA.Certificate> factoryAction = null) : ResourceFactory<Humidifier.ACMPCA.Certificate>(resourceName)
{

    internal InnerCertificateValidityFactory ValidityFactory { get; set; }

    internal InnerCertificateApiPassthroughFactory ApiPassthroughFactory { get; set; }

    internal InnerCertificateValidityFactory ValidityNotBeforeFactory { get; set; }

    protected override Humidifier.ACMPCA.Certificate Create()
    {
        var certificateResult = CreateCertificate();
        factoryAction?.Invoke(certificateResult);

        return certificateResult;
    }

    private Humidifier.ACMPCA.Certificate CreateCertificate()
    {
        var certificateResult = new Humidifier.ACMPCA.Certificate
        {
            GivenName = InputResourceName,
        };

        return certificateResult;
    }
    public override void CreateChildren(Humidifier.ACMPCA.Certificate result)
    {
        base.CreateChildren(result);

        result.Validity ??= ValidityFactory?.Build();
        result.ApiPassthrough ??= ApiPassthroughFactory?.Build();
        result.ValidityNotBefore ??= ValidityNotBeforeFactory?.Build();
    }

} // End Of Class

public static class CertificateFactoryExtensions
{
    public static CombinedResult<CertificateFactory, InnerCertificateValidityFactory> WithValidity(this CertificateFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null)
    {
        parentFactory.ValidityFactory = new InnerCertificateValidityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidityFactory);
    }

    public static CombinedResult<CertificateFactory, InnerCertificateApiPassthroughFactory> WithApiPassthrough(this CertificateFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null)
    {
        parentFactory.ApiPassthroughFactory = new InnerCertificateApiPassthroughFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApiPassthroughFactory);
    }

    public static CombinedResult<CertificateFactory, InnerCertificateValidityFactory> WithValidityNotBefore(this CertificateFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null)
    {
        parentFactory.ValidityNotBeforeFactory = new InnerCertificateValidityFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidityNotBeforeFactory);
    }

    public static CombinedResult<CertificateFactory, T1, InnerCertificateValidityFactory> WithValidity<T1>(this CombinedResult<CertificateFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, InnerCertificateValidityFactory> WithValidity<T1>(this CombinedResult<T1, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, InnerCertificateValidityFactory> WithValidity<T1, T2>(this CombinedResult<CertificateFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, InnerCertificateValidityFactory> WithValidity<T1, T2>(this CombinedResult<T1, CertificateFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, InnerCertificateValidityFactory> WithValidity<T1, T2>(this CombinedResult<T1, T2, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, InnerCertificateValidityFactory> WithValidity<T1, T2, T3>(this CombinedResult<CertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, InnerCertificateValidityFactory> WithValidity<T1, T2, T3>(this CombinedResult<T1, CertificateFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, InnerCertificateValidityFactory> WithValidity<T1, T2, T3>(this CombinedResult<T1, T2, CertificateFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, InnerCertificateValidityFactory> WithValidity<T1, T2, T3>(this CombinedResult<T1, T2, T3, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, T4, InnerCertificateValidityFactory> WithValidity<T1, T2, T3, T4>(this CombinedResult<CertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, T4, InnerCertificateValidityFactory> WithValidity<T1, T2, T3, T4>(this CombinedResult<T1, CertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, T4, InnerCertificateValidityFactory> WithValidity<T1, T2, T3, T4>(this CombinedResult<T1, T2, CertificateFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, T4, InnerCertificateValidityFactory> WithValidity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CertificateFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CertificateFactory, InnerCertificateValidityFactory> WithValidity<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidity(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1>(this CombinedResult<CertificateFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1>(this CombinedResult<T1, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, WithApiPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2>(this CombinedResult<CertificateFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2>(this CombinedResult<T1, CertificateFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2>(this CombinedResult<T1, T2, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3>(this CombinedResult<CertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3>(this CombinedResult<T1, CertificateFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3>(this CombinedResult<T1, T2, CertificateFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3>(this CombinedResult<T1, T2, T3, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, T4, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3, T4>(this CombinedResult<CertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, T4, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, CertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, T4, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, CertificateFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, T4, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CertificateFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CertificateFactory, InnerCertificateApiPassthroughFactory> WithApiPassthrough<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApiPassthrough(combinedResult.T5, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, InnerCertificateValidityFactory> WithValidityNotBefore<T1>(this CombinedResult<CertificateFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, InnerCertificateValidityFactory> WithValidityNotBefore<T1>(this CombinedResult<T1, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2>(this CombinedResult<CertificateFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2>(this CombinedResult<T1, CertificateFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2>(this CombinedResult<T1, T2, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3>(this CombinedResult<CertificateFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3>(this CombinedResult<T1, CertificateFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3>(this CombinedResult<T1, T2, CertificateFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3>(this CombinedResult<T1, T2, T3, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T4, subFactoryAction));
    public static CombinedResult<CertificateFactory, T1, T2, T3, T4, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3, T4>(this CombinedResult<CertificateFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, CertificateFactory, T2, T3, T4, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3, T4>(this CombinedResult<T1, CertificateFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, CertificateFactory, T3, T4, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3, T4>(this CombinedResult<T1, T2, CertificateFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, CertificateFactory, T4, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CertificateFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, CertificateFactory, InnerCertificateValidityFactory> WithValidityNotBefore<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CertificateFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Validity> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityNotBefore(combinedResult.T5, subFactoryAction));
}
