// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageDriftCheckExplainabilityFactory(Action<Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability>
{

    internal InnerModelPackageMetricsSourceFactory ConstraintsFactory { get; set; }

    internal InnerModelPackageFileSourceFactory ConfigFileFactory { get; set; }

    protected override Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability Create()
    {
        var driftCheckExplainabilityResult = CreateDriftCheckExplainability();
        factoryAction?.Invoke(driftCheckExplainabilityResult);

        return driftCheckExplainabilityResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability CreateDriftCheckExplainability()
    {
        var driftCheckExplainabilityResult = new Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability();

        return driftCheckExplainabilityResult;
    }
    public override void CreateChildren(Humidifier.SageMaker.ModelPackageTypes.DriftCheckExplainability result)
    {
        base.CreateChildren(result);

        result.Constraints ??= ConstraintsFactory?.Build();
        result.ConfigFile ??= ConfigFileFactory?.Build();
    }

} // End Of Class

public static class InnerModelPackageDriftCheckExplainabilityFactoryExtensions
{
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints(this InnerModelPackageDriftCheckExplainabilityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null)
    {
        parentFactory.ConstraintsFactory = new InnerModelPackageMetricsSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConstraintsFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageFileSourceFactory> WithConfigFile(this InnerModelPackageDriftCheckExplainabilityFactory parentFactory, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null)
    {
        parentFactory.ConfigFileFactory = new InnerModelPackageFileSourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigFileFactory);
    }

    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, T4, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageMetricsSourceFactory> WithConstraints<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.MetricsSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConstraints(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, InnerModelPackageFileSourceFactory> WithConfigFile<T1>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageFileSourceFactory> WithConfigFile<T1>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, T4, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3, T4>(this CombinedResult<InnerModelPackageDriftCheckExplainabilityFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, T4, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3, T4>(this CombinedResult<T1, InnerModelPackageDriftCheckExplainabilityFactory, T2, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, T4, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerModelPackageDriftCheckExplainabilityFactory, T3, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, T4, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerModelPackageDriftCheckExplainabilityFactory, T4> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckExplainabilityFactory, InnerModelPackageFileSourceFactory> WithConfigFile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerModelPackageDriftCheckExplainabilityFactory> combinedResult, Action<Humidifier.SageMaker.ModelPackageTypes.FileSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigFile(combinedResult.T5, subFactoryAction));
}
