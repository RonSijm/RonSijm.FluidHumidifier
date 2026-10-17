// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Chime;

public class MediaStreamPipelineFactory(string resourceName = null, Action<Humidifier.Chime.MediaStreamPipeline> factoryAction = null) : ResourceFactory<Humidifier.Chime.MediaStreamPipeline>(resourceName)
{

    internal List<InnerMediaStreamPipelineMediaStreamSinkFactory> SinksFactories { get; set; } = [];

    internal List<InnerMediaStreamPipelineMediaStreamSourceFactory> SourcesFactories { get; set; } = [];

    protected override Humidifier.Chime.MediaStreamPipeline Create()
    {
        var mediaStreamPipelineResult = CreateMediaStreamPipeline();
        factoryAction?.Invoke(mediaStreamPipelineResult);

        return mediaStreamPipelineResult;
    }

    private Humidifier.Chime.MediaStreamPipeline CreateMediaStreamPipeline()
    {
        var mediaStreamPipelineResult = new Humidifier.Chime.MediaStreamPipeline
        {
            GivenName = InputResourceName,
        };

        return mediaStreamPipelineResult;
    }
    public override void CreateChildren(Humidifier.Chime.MediaStreamPipeline result)
    {
        base.CreateChildren(result);

        result.Sinks = SinksFactories.Any() ? SinksFactories.Select(x => x.Build()).ToList() : null;
        result.Sources = SourcesFactories.Any() ? SourcesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class MediaStreamPipelineFactoryExtensions
{
    public static CombinedResult<MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks(this MediaStreamPipelineFactory parentFactory, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null)
    {
        var factory = new InnerMediaStreamPipelineMediaStreamSinkFactory(subFactoryAction);
        parentFactory.SinksFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources(this MediaStreamPipelineFactory parentFactory, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null)
    {
        var factory = new InnerMediaStreamPipelineMediaStreamSourceFactory(subFactoryAction);
        parentFactory.SourcesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<MediaStreamPipelineFactory, T1, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1>(this CombinedResult<MediaStreamPipelineFactory, T1> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1>(this CombinedResult<T1, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2>(this CombinedResult<MediaStreamPipelineFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2>(this CombinedResult<T1, MediaStreamPipelineFactory, T2> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2>(this CombinedResult<T1, T2, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<MediaStreamPipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, MediaStreamPipelineFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, T2, MediaStreamPipelineFactory, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3>(this CombinedResult<T1, T2, T3, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, T4, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, T4, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, T4, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, T4, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSinkFactory> WithSinks<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSink> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSinks(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1>(this CombinedResult<MediaStreamPipelineFactory, T1> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1>(this CombinedResult<T1, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2>(this CombinedResult<MediaStreamPipelineFactory, T1, T2> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, MediaStreamPipelineFactory, T2> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2>(this CombinedResult<T1, T2, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<MediaStreamPipelineFactory, T1, T2, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, MediaStreamPipelineFactory, T2, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, MediaStreamPipelineFactory, T3> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3>(this CombinedResult<T1, T2, T3, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, T4, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<MediaStreamPipelineFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, T4, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, MediaStreamPipelineFactory, T2, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, T4, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, MediaStreamPipelineFactory, T3, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, T4, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, MediaStreamPipelineFactory, T4> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, MediaStreamPipelineFactory, InnerMediaStreamPipelineMediaStreamSourceFactory> WithSources<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, MediaStreamPipelineFactory> combinedResult, Action<Humidifier.Chime.MediaStreamPipelineTypes.MediaStreamSource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSources(combinedResult.T5, subFactoryAction).T2);
}
