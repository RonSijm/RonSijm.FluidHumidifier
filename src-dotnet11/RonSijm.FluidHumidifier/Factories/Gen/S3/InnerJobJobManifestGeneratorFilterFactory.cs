// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobManifestGeneratorFilterFactory(Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobManifestGeneratorFilter>
{

    internal InnerJobKeyNameConstraintFactory KeyNameConstraintFactory { get; set; }

    protected override Humidifier.S3.JobTypes.JobManifestGeneratorFilter Create()
    {
        var jobManifestGeneratorFilterResult = CreateJobManifestGeneratorFilter();
        factoryAction?.Invoke(jobManifestGeneratorFilterResult);

        return jobManifestGeneratorFilterResult;
    }

    private Humidifier.S3.JobTypes.JobManifestGeneratorFilter CreateJobManifestGeneratorFilter()
    {
        var jobManifestGeneratorFilterResult = new Humidifier.S3.JobTypes.JobManifestGeneratorFilter();

        return jobManifestGeneratorFilterResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.JobManifestGeneratorFilter result)
    {
        base.CreateChildren(result);

        result.KeyNameConstraint ??= KeyNameConstraintFactory?.Build();
    }

} // End Of Class

public static class InnerJobJobManifestGeneratorFilterFactoryExtensions
{
    public static CombinedResult<InnerJobJobManifestGeneratorFilterFactory, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint(this InnerJobJobManifestGeneratorFilterFactory parentFactory, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null)
    {
        parentFactory.KeyNameConstraintFactory = new InnerJobKeyNameConstraintFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.KeyNameConstraintFactory);
    }

    public static CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1>(this CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1>(this CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2>(this CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2>(this CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2, T3, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3>(this CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2, T3, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3>(this CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory, T3, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFilterFactory, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFilterFactory> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2, T3, T4, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3, T4>(this CombinedResult<InnerJobJobManifestGeneratorFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2, T3, T4, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobManifestGeneratorFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory, T3, T4, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFilterFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFilterFactory, T4, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFilterFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobManifestGeneratorFilterFactory, InnerJobKeyNameConstraintFactory> WithKeyNameConstraint<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobManifestGeneratorFilterFactory> combinedResult, Action<Humidifier.S3.JobTypes.KeyNameConstraint> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithKeyNameConstraint(combinedResult.T5, subFactoryAction).T2);
}
