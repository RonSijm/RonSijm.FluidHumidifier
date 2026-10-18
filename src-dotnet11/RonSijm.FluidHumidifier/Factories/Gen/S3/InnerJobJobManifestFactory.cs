// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobManifestFactory(Action<Humidifier.S3.JobTypes.JobManifest> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobManifest>
{

    internal InnerJobJobManifestSpecFactory SpecFactory { get; set; }

    internal InnerJobJobManifestLocationFactory LocationFactory { get; set; }

    protected override Humidifier.S3.JobTypes.JobManifest Create()
    {
        var jobManifestResult = CreateJobManifest();
        factoryAction?.Invoke(jobManifestResult);

        return jobManifestResult;
    }

    private Humidifier.S3.JobTypes.JobManifest CreateJobManifest()
    {
        var jobManifestResult = new Humidifier.S3.JobTypes.JobManifest();

        return jobManifestResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.JobManifest result)
    {
        base.CreateChildren(result);

        result.Spec ??= SpecFactory?.Build();
        result.Location ??= LocationFactory?.Build();
    }

} // End Of Class

public static class InnerJobJobManifestFactoryExtensions
{
    public static CombinedResult<InnerJobJobManifestFactory, InnerJobJobManifestSpecFactory> WithSpec(this InnerJobJobManifestFactory parentFactory, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null)
    {
        parentFactory.SpecFactory = new InnerJobJobManifestSpecFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SpecFactory);
    }

    public static CombinedResult<InnerJobJobManifestFactory, InnerJobJobManifestLocationFactory> WithLocation(this InnerJobJobManifestFactory parentFactory, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null)
    {
        parentFactory.LocationFactory = new InnerJobJobManifestLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LocationFactory);
    }

    public static CombinedResult<InnerJobJobManifestFactory, T1, InnerJobJobManifestSpecFactory> WithSpec<T1>(this CombinedResult<InnerJobJobManifestFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, InnerJobJobManifestSpecFactory> WithSpec<T1>(this CombinedResult<T1, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, InnerJobJobManifestSpecFactory> WithSpec<T1, T2>(this CombinedResult<InnerJobJobManifestFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, InnerJobJobManifestSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, InnerJobJobManifestFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, InnerJobJobManifestSpecFactory> WithSpec<T1, T2>(this CombinedResult<T1, T2, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<InnerJobJobManifestFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, InnerJobJobManifestFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobManifestFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, T4, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, T4, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, T4, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, T4, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobManifestFactory, InnerJobJobManifestSpecFactory> WithSpec<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestSpec> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSpec(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, InnerJobJobManifestLocationFactory> WithLocation<T1>(this CombinedResult<InnerJobJobManifestFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, InnerJobJobManifestLocationFactory> WithLocation<T1>(this CombinedResult<T1, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, InnerJobJobManifestLocationFactory> WithLocation<T1, T2>(this CombinedResult<InnerJobJobManifestFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, InnerJobJobManifestLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, InnerJobJobManifestFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, InnerJobJobManifestLocationFactory> WithLocation<T1, T2>(this CombinedResult<T1, T2, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<InnerJobJobManifestFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, InnerJobJobManifestFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobManifestFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, T4, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<InnerJobJobManifestFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, T4, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobManifestFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, T4, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobManifestFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, T4, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobManifestFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobManifestFactory, InnerJobJobManifestLocationFactory> WithLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobManifestFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLocation(combinedResult.T5, subFactoryAction).T2);
}
