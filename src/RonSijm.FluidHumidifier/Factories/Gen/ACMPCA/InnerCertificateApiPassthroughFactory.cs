// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ACMPCA;

public class InnerCertificateApiPassthroughFactory(Action<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough> factoryAction = null) : SubResourceFactory<Humidifier.ACMPCA.CertificateTypes.ApiPassthrough>
{

    internal InnerCertificateExtensionsFactory ExtensionsFactory { get; set; }

    internal InnerCertificateSubjectFactory SubjectFactory { get; set; }

    protected override Humidifier.ACMPCA.CertificateTypes.ApiPassthrough Create()
    {
        var apiPassthroughResult = CreateApiPassthrough();
        factoryAction?.Invoke(apiPassthroughResult);

        return apiPassthroughResult;
    }

    private Humidifier.ACMPCA.CertificateTypes.ApiPassthrough CreateApiPassthrough()
    {
        var apiPassthroughResult = new Humidifier.ACMPCA.CertificateTypes.ApiPassthrough();

        return apiPassthroughResult;
    }
    public override void CreateChildren(Humidifier.ACMPCA.CertificateTypes.ApiPassthrough result)
    {
        base.CreateChildren(result);

        result.Extensions ??= ExtensionsFactory?.Build();
        result.Subject ??= SubjectFactory?.Build();
    }

} // End Of Class

public static class InnerCertificateApiPassthroughFactoryExtensions
{
    public static CombinedResult<InnerCertificateApiPassthroughFactory, InnerCertificateExtensionsFactory> WithExtensions(this InnerCertificateApiPassthroughFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null)
    {
        parentFactory.ExtensionsFactory = new InnerCertificateExtensionsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ExtensionsFactory);
    }

    public static CombinedResult<InnerCertificateApiPassthroughFactory, InnerCertificateSubjectFactory> WithSubject(this InnerCertificateApiPassthroughFactory parentFactory, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null)
    {
        parentFactory.SubjectFactory = new InnerCertificateSubjectFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SubjectFactory);
    }

    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, InnerCertificateExtensionsFactory> WithExtensions<T1>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExtensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, InnerCertificateExtensionsFactory> WithExtensions<T1>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, WithExtensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, InnerCertificateExtensionsFactory> WithExtensions<T1, T2>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, InnerCertificateExtensionsFactory> WithExtensions<T1, T2>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, InnerCertificateExtensionsFactory> WithExtensions<T1, T2>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, T4, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3, T4>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, T4, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3, T4>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, T4, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, T4, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCertificateApiPassthroughFactory, InnerCertificateExtensionsFactory> WithExtensions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Extensions> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExtensions(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, InnerCertificateSubjectFactory> WithSubject<T1>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, InnerCertificateSubjectFactory> WithSubject<T1>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, InnerCertificateSubjectFactory> WithSubject<T1, T2>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, InnerCertificateSubjectFactory> WithSubject<T1, T2>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, InnerCertificateSubjectFactory> WithSubject<T1, T2>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, T4, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3, T4>(this CombinedResult<InnerCertificateApiPassthroughFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, T4, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3, T4>(this CombinedResult<T1, InnerCertificateApiPassthroughFactory, T2, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, T4, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerCertificateApiPassthroughFactory, T3, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, T4, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerCertificateApiPassthroughFactory, T4> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerCertificateApiPassthroughFactory, InnerCertificateSubjectFactory> WithSubject<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerCertificateApiPassthroughFactory> combinedResult, Action<Humidifier.ACMPCA.CertificateTypes.Subject> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubject(combinedResult.T5, subFactoryAction));
}
