// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageModelQualityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.ModelQuality> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.ModelQuality>
{

    internal InnerModelPackageMetricsSourceFactory ConstraintsFactory { get; set; }

    internal InnerModelPackageMetricsSourceFactory StatisticsFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.ModelQuality Create()
    {
        var modelQualityResult = CreateModelQuality();
        factoryAction?.Invoke(modelQualityResult);

        return modelQualityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.ModelQuality CreateModelQuality()
    {
        var modelQualityResult = new Humidifier.SageMaker.ModelPackageTypes.ModelQuality();

        return modelQualityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.ModelQuality result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
        result.Statistics ??= StatisticsFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageModelQualityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints(this InnerModelPackageModelQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics(this InnerModelPackageModelQualityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.StatisticsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatisticsFactory);
    }

    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<InnerModelPackageModelQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<T1, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<InnerModelPackageModelQualityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1>(this CombinedResult<T1, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageModelQualityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageModelQualityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageModelQualityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, T4, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageModelQualityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageModelQualityFactory, InnerModelPackageMetricsSourceFactory> WithStatistics<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageModelQualityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatistics(combinedResult.T5, subFactoryAction));
}
