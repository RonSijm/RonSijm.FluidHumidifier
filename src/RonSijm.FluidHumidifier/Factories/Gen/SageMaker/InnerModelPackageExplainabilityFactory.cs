// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageExplainabilityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.Explainability> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.Explainability>
{

    internal InnerModelPackageMetricsSourceFactory ReportFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.Explainability Create()
    {
        var explainabilityResult = CreateExplainability();
        factoryAction?.Invoke(explainabilityResult);

        return explainabilityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.Explainability CreateExplainability()
    {
        var explainabilityResult = new Humidifier.SageMaker.ModelPackageTypes.Explainability();

        return explainabilityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.Explainability result)
    {
        base.CreateChildren(result);

        result.Report ??= ReportFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageExplainabilityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithReport(this InnerModelPackageExplainabilityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ReportFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ReportFactory);
    }

    public static CombinedResult<InnerModelPackageExplainabilityFactory, T1, InnerModelPackageMetricsSourceFactory> WithReport<T1>(this CombinedResult<InnerModelPackageExplainabilityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithReport<T1>(this CombinedResult<T1, InnerModelPackageExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2>(this CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2>(this CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3>(this CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory, T3, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageExplainabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageExplainabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageExplainabilityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageExplainabilityFactory, T4, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageExplainabilityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithReport<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithReport(combinedResult.T5, subFactoryAction));
}
