// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class InnerMediaConcatenationPipelineConcatenationSinkFactory(Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> factoryAction = null) : SubResourceFactory<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink>
{

    internal InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory S3BucketSinkConfigurationFactory { get; set; }

    protected override Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink Create()
    {
        var concatenationSinkResult = CreateConcatenationSink();
        factoryAction?.Invoke(concatenationSinkResult);

        return concatenationSinkResult;
    }

    private Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink CreateConcatenationSink()
    {
        var concatenationSinkResult = new Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink();

        return concatenationSinkResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink result)
    {
        base.CreateChildren(result);

        result.S3BucketSinkConfiguration ??= S3BucketSinkConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerMediaConcatenationPipelineConcatenationSinkFactoryExtensions
{
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration(this InnerMediaConcatenationPipelineConcatenationSinkFactory parentFactory, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null)
    {
        parentFactory.S3BucketSinkConfigurationFactory = new InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3BucketSinkConfigurationFactory);
    }

    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2, T3, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2, T3, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory, T3, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2, T3, T4, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerMediaConcatenationPipelineConcatenationSinkFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2, T3, T4, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerMediaConcatenationPipelineConcatenationSinkFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory, T3, T4, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory, T4, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory, InnerMediaConcatenationPipelineS3BucketSinkConfigurationFactory> WithS3BucketSinkConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.S3BucketSinkConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3BucketSinkConfiguration(combinedResult.T5, subFactoryAction).T2);
}
