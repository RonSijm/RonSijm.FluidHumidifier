// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerJobJobManifestGeneratorFactory(Action<Humidifier.S3.JobTypes.JobManifestGenerator> factoryAction = null) : SubResourceFactory<Humidifier.S3.JobTypes.JobManifestGenerator>
{

    internal InnerJobS3JobManifestGeneratorFactory S3JobManifestGeneratorFactory { get; set; }

    protected override Humidifier.S3.JobTypes.JobManifestGenerator Create()
    {
        var jobManifestGeneratorResult = CreateJobManifestGenerator();
        factoryAction?.Invoke(jobManifestGeneratorResult);

        return jobManifestGeneratorResult;
    }

    private Humidifier.S3.JobTypes.JobManifestGenerator CreateJobManifestGenerator()
    {
        var jobManifestGeneratorResult = new Humidifier.S3.JobTypes.JobManifestGenerator();

        return jobManifestGeneratorResult;
    }
    public override void CreateChildren(Humidifier.S3.JobTypes.JobManifestGenerator result)
    {
        base.CreateChildren(result);

        result.S3JobManifestGenerator ??= S3JobManifestGeneratorFactory?.Build();
    }

} // End Of Class

public static class InnerJobJobManifestGeneratorFactoryExtensions
{
    public static CombinedResult<InnerJobJobManifestGeneratorFactory, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator(this InnerJobJobManifestGeneratorFactory parentFactory, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null)
    {
        parentFactory.S3JobManifestGeneratorFactory = new InnerJobS3JobManifestGeneratorFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3JobManifestGeneratorFactory);
    }

    public static CombinedResult<InnerJobJobManifestGeneratorFactory, T1, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1>(this CombinedResult<InnerJobJobManifestGeneratorFactory, T1> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFactory, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1>(this CombinedResult<T1, InnerJobJobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2>(this CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2>(this CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2, T3, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3>(this CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2, T3, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3>(this CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory, T3, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory, T3> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFactory, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3, T4>(this CombinedResult<InnerJobJobManifestGeneratorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2, T3, T4, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, InnerJobJobManifestGeneratorFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory, T3, T4, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerJobJobManifestGeneratorFactory, T3, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFactory, T4, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerJobJobManifestGeneratorFactory, T4> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerJobJobManifestGeneratorFactory, InnerJobS3JobManifestGeneratorFactory> WithS3JobManifestGenerator<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerJobJobManifestGeneratorFactory> combinedResult, Action<Humidifier.S3.JobTypes.S3JobManifestGenerator> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3JobManifestGenerator(combinedResult.T5, subFactoryAction).T2);
}
