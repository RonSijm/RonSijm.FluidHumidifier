// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageModelDataQualityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality>
{

    internal InnerModelPackageMetricsSourceFactory ConstraintsFactory { get; set; }

    internal InnerModelPackageMetricsSourceFactory StatisticsFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality Create()
    {
        var modelDataQualityResult = CreateModelDataQuality();
        factoryAction?.Invoke(modelDataQualityResult);

        return modelDataQualityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality CreateModelDataQuality()
    {
        var modelDataQualityResult = new Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality();

        return modelDataQualityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.ModelDataQuality result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
        result.Statistics ??= StatisticsFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageModelDataQualityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints(this InnerModelPackageModelDataQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics(this InnerModelPackageModelDataQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.StatisticsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatisticsFactory);
    }

    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageModelDataQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageModelDataQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageModelDataQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageModelDataQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageModelDataQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageModelDataQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T5, subFactoryAction));
}
