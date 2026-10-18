// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class ReportGeneratorFactory(string resourceName = null, Action<Humidifier.LicenseManager.ReportGenerator> factoryAction = null) : ResourceFactory<Humidifier.LicenseManager.ReportGenerator>(resourceName)
{

    internal InnerReportGeneratorReportContextFactory ReportContextFactory { get; set; }

    internal InnerReportGeneratorReportFrequencyFactory ReportFrequencyFactory { get; set; }

    protected override Humidifier.LicenseManager.ReportGenerator Create()
    {
        var reportGeneratorResult = CreateReportGenerator();
        factoryAction?.Invoke(reportGeneratorResult);

        return reportGeneratorResult;
    }

    private Humidifier.LicenseManager.ReportGenerator CreateReportGenerator()
    {
        var reportGeneratorResult = new Humidifier.LicenseManager.ReportGenerator
        {
            GivenName = InputResourceName,
        };

        return reportGeneratorResult;
    }
    public override void CreateChildren(Humidifier.LicenseManager.ReportGenerator result)
    {
        base.CreateChildren(result);

        result.ReportContext ??= ReportContextFactory?.Build();
        result.ReportFrequency ??= ReportFrequencyFactory?.Build();
    }

} // End Of Class

public static class ReportGeneratorFactoryExtensions
{
    public static CombinedResult<ReportGeneratorFactory, InnerReportGeneratorReportContextFactory> WithReportContext(this ReportGeneratorFactory parentFactory, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null)
    {
        parentFactory.ReportContextFactory = new InnerReportGeneratorReportContextFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportContextFactory);
    }

    public static CombinedResult<ReportGeneratorFactory, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency(this ReportGeneratorFactory parentFactory, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null)
    {
        parentFactory.ReportFrequencyFactory = new InnerReportGeneratorReportFrequencyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportFrequencyFactory);
    }

    public static CombinedResult<ReportGeneratorFactory, T1, InnerReportGeneratorReportContextFactory> WithReportContext<T1>(this CombinedResult<ReportGeneratorFactory, T1> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, InnerReportGeneratorReportContextFactory> WithReportContext<T1>(this CombinedResult<T1, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2>(this CombinedResult<ReportGeneratorFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2>(this CombinedResult<T1, ReportGeneratorFactory, T2> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2>(this CombinedResult<T1, T2, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, T3, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3>(this CombinedResult<ReportGeneratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, T3, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3>(this CombinedResult<T1, ReportGeneratorFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, T3, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3>(this CombinedResult<T1, T2, ReportGeneratorFactory, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReportGeneratorFactory, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, T3, T4, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3, T4>(this CombinedResult<ReportGeneratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, T3, T4, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3, T4>(this CombinedResult<T1, ReportGeneratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, T3, T4, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReportGeneratorFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReportGeneratorFactory, T4, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReportGeneratorFactory, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReportGeneratorFactory, InnerReportGeneratorReportContextFactory> WithReportContext<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportContext(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1>(this CombinedResult<ReportGeneratorFactory, T1> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1>(this CombinedResult<T1, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, WithReportFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2>(this CombinedResult<ReportGeneratorFactory, T1, T2> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2>(this CombinedResult<T1, ReportGeneratorFactory, T2> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2>(this CombinedResult<T1, T2, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, T3, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3>(this CombinedResult<ReportGeneratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, T3, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3>(this CombinedResult<T1, ReportGeneratorFactory, T2, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, T3, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3>(this CombinedResult<T1, T2, ReportGeneratorFactory, T3> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReportGeneratorFactory, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3>(this CombinedResult<T1, T2, T3, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<ReportGeneratorFactory, T1, T2, T3, T4, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3, T4>(this CombinedResult<ReportGeneratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, ReportGeneratorFactory, T2, T3, T4, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3, T4>(this CombinedResult<T1, ReportGeneratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, ReportGeneratorFactory, T3, T4, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, ReportGeneratorFactory, T3, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, ReportGeneratorFactory, T4, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ReportGeneratorFactory, T4> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, ReportGeneratorFactory, InnerReportGeneratorReportFrequencyFactory> WithReportFrequency<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ReportGeneratorFactory> combinedResult, Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReportFrequency(combinedResult.T5, subFactoryAction).T2);
}
