// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.PCAConnectorAD;

public class InnerTemplateCertificateValidityFactory(Action<Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity> factoryAction = null) : SubResourceFactory<Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity>
{

    internal InnerTemplateValidityPeriodFactory ValidityPeriodFactory { get; set; }

    internal InnerTemplateValidityPeriodFactory RenewalPeriodFactory { get; set; }

    protected override Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity Create()
    {
        var certificateValidityResult = CreateCertificateValidity();
        factoryAction?.Invoke(certificateValidityResult);

        return certificateValidityResult;
    }

    private Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity CreateCertificateValidity()
    {
        var certificateValidityResult = new Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity();

        return certificateValidityResult;
    }
    public override void CreateChildren(Humidifier.PCAConnectorAD.TemplateTypes.CertificateValidity result)
    {
        base.CreateChildren(result);

        result.ValidityPeriod ??= ValidityPeriodFactory?.Build();
        result.RenewalPeriod ??= RenewalPeriodFactory?.Build();
    }

} // End Of Class

public static class InnerTemplateCertificateValidityFactoryExtensions
{
    public static CombinedResult<InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithValidityPeriod(this InnerTemplateCertificateValidityFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null)
    {
        parentFactory.ValidityPeriodFactory = new InnerTemplateValidityPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValidityPeriodFactory);
    }

    public static CombinedResult<InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithRenewalPeriod(this InnerTemplateCertificateValidityFactory parentFactory, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null)
    {
        parentFactory.RenewalPeriodFactory = new InnerTemplateValidityPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RenewalPeriodFactory);
    }

    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, T4, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3, T4>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, T4, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, T4, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, T4, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithValidityPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValidityPeriod(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, T4, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3, T4>(this CombinedResult<InnerTemplateCertificateValidityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, T4, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3, T4>(this CombinedResult<T1, InnerTemplateCertificateValidityFactory, T2, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, T4, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerTemplateCertificateValidityFactory, T3, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, T4, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerTemplateCertificateValidityFactory, T4> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerTemplateCertificateValidityFactory, InnerTemplateValidityPeriodFactory> WithRenewalPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerTemplateCertificateValidityFactory> combinedResult, Action<Humidifier.PCAConnectorAD.TemplateTypes.ValidityPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRenewalPeriod(combinedResult.T5, subFactoryAction));
}
