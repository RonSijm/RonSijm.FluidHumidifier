// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageDriftCheckModelDataQualityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality>
{

    internal InnerModelPackageMetricsSourceFactory ConstraintsFactory { get; set; }

    internal InnerModelPackageMetricsSourceFactory StatisticsFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality Create()
    {
        var driftCheckModelDataQualityResult = CreateDriftCheckModelDataQuality();
        factoryAction?.Invoke(driftCheckModelDataQualityResult);

        return driftCheckModelDataQualityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality CreateDriftCheckModelDataQuality()
    {
        var driftCheckModelDataQualityResult = new Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality();

        return driftCheckModelDataQualityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelDataQuality result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
        result.Statistics ??= StatisticsFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageDriftCheckModelDataQualityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints(this InnerModelPackageDriftCheckModelDataQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics(this InnerModelPackageDriftCheckModelDataQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.StatisticsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatisticsFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckModelDataQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckModelDataQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelDataQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelDataQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T5, subFactoryAction));
}
