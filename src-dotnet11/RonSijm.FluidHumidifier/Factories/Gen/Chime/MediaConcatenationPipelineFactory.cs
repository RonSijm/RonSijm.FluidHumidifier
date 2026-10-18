// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class MediaConcatenationPipelineFactory(string resourceName = null, Action<Humidifier.Chime.MediaConcatenationPipeline> factoryAction = null) : ResourceFactory<Humidifier.Chime.MediaConcatenationPipeline>(resourceName)
{

    internal List<InnerMediaConcatenationPipelineConcatenationSinkFactory> SinksFactories { get; set; } = [];

    internal List<InnerMediaConcatenationPipelineConcatenationSourceFactory> SourcesFactories { get; set; } = [];

    protected override Humidifier.Chime.MediaConcatenationPipeline Create()
    {
        var mediaConcatenationPipelineResult = CreateMediaConcatenationPipeline();
        factoryAction?.Invoke(mediaConcatenationPipelineResult);

        return mediaConcatenationPipelineResult;
    }

    private Humidifier.Chime.MediaConcatenationPipeline CreateMediaConcatenationPipeline()
    {
        var mediaConcatenationPipelineResult = new Humidifier.Chime.MediaConcatenationPipeline
        {
            GivenName = InputResourceName,
        };

        return mediaConcatenationPipelineResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaConcatenationPipeline result)
    {
        base.CreateChildren(result);

        result.Sinks = SinksFactories.Any() ? SinksFactories.Select(x => x.Build()).ToList() : null;
        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MediaConcatenationPipelineFactoryExtensions
{
    public static CombinedResult<MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks(this MediaConcatenationPipelineFactory parentFactory, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null)
    {
        var factory = new InnerMediaConcatenationPipelineConcatenationSinkFactory(subFactoryAction);
        parentFactory.SinksFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources(this MediaConcatenationPipelineFactory parentFactory, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null)
    {
        var factory = new InnerMediaConcatenationPipelineConcatenationSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1>(this CombinedResult<MediaConcatenationPipelineFactory, T1> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1>(this CombinedResult<T1, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, T4, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1>(this CombinedResult<MediaConcatenationPipelineFactory, T1> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1>(this CombinedResult<T1, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<MediaConcatenationPipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, MediaConcatenationPipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, MediaConcatenationPipelineFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, T4, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MediaConcatenationPipelineFactory, T4> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MediaConcatenationPipelineFactory, InnerMediaConcatenationPipelineConcatenationSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MediaConcatenationPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaConcatenationPipelineTypes.ConcatenationSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction).T2);
}
