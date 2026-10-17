// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobS3JobManifestGeneratorFactory(Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.S3JobManifestGenerator>
{

    internal InnerJobJobManifestGeneratorFilterFactory FilterFactory { get; set; }

    internal InnerJobS3ManifestOutputLocationFactory ManifestOutputLocationFactory { get; set; }

    protected override Humidifier.S3.JobTypes.S3JobManifestGenerator Create()
    {
        var s3JobManifestGeneratorResult = CreateS3JobManifestGenerator();
        factoryAction?.Invoke(s3JobManifestGeneratorResult);

        return s3JobManifestGeneratorResult;
    }

    private Humidifier.S3.JobTypes.S3JobManifestGenerator CreateS3JobManifestGenerator()
    {
        var s3JobManifestGeneratorResult = new Humidifier.S3.JobTypes.S3JobManifestGenerator();

        return s3JobManifestGeneratorResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.S3JobManifestGenerator result)
    {
        base.CreateChildren(result);

        result.Filter ??= FilterFactory?.Build();
        result.ManifestOutputLocation ??= ManifestOutputLocationFactory?.Build();
    }

} // End Of Class

public static class InnerJobS3JobManifestGeneratorFactoryExtensions
{
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, InnerJobJobManifestGeneratorFilterFactory> WithFilter(this InnerJobS3JobManifestGeneratorFactory parentFactory, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null)
    {
        parentFactory.FilterFactory = new InnerJobJobManifestGeneratorFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterFactory);
    }

    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation(this InnerJobS3JobManifestGeneratorFactory parentFactory, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null)
    {
        parentFactory.ManifestOutputLocationFactory = new InnerJobS3ManifestOutputLocationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ManifestOutputLocationFactory);
    }

    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, T4, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, T4, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, T4, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, T4, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory, InnerJobJobManifestGeneratorFilterFactory> WithFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.JobManifestGeneratorFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilter(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, T4, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3, T4>(this CombinedResult<InnerJobS3JobManifestGeneratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, T4, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobS3JobManifestGeneratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, T4, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobS3JobManifestGeneratorFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, T4, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobS3JobManifestGeneratorFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory, InnerJobS3ManifestOutputLocationFactory> WithManifestOutputLocation<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3ManifestOutputLocation> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithManifestOutputLocation(combinedResult.T5, subFactoryAction).T2);
}
