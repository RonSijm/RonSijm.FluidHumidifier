// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageDriftCheckModelQualityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality>
{

    internal InnerModelPackageMetricsSourceFactory ConstraintsFactory { get; set; }

    internal InnerModelPackageMetricsSourceFactory StatisticsFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality Create()
    {
        var driftCheckModelQualityResult = CreateDriftCheckModelQuality();
        factoryAction?.Invoke(driftCheckModelQualityResult);

        return driftCheckModelQualityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality CreateDriftCheckModelQuality()
    {
        var driftCheckModelQualityResult = new Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality();

        return driftCheckModelQualityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.DriftCheckModelQuality result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
        result.Statistics ??= StatisticsFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageDriftCheckModelQualityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints(this InnerModelPackageDriftCheckModelQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics(this InnerModelPackageDriftCheckModelQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.StatisticsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatisticsFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckModelQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckModelQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckModelQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckModelQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T5, subFactoryAction));
}
