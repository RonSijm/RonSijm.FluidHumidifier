// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class SdiSourceFactory(string resourceName = null, Action<Humidifier.MediaLive.SdiSource> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.SdiSource>(resourceName)
{

    internal List<InnerSdiSourceTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.MediaLive.SdiSource Create()
    {
        var sdiSourceResult = CreateSdiSource();
        factoryAction?.Invoke(sdiSourceResult);

        return sdiSourceResult;
    }

    private Humidifier.MediaLive.SdiSource CreateSdiSource()
    {
        var sdiSourceResult = new Humidifier.MediaLive.SdiSource
        {
            GivenName = InputResourceName,
        };

        return sdiSourceResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.SdiSource result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class SdiSourceFactoryExtensions
{
    public static CombinedResult<SdiSourceFactory, InnerSdiSourceTagsFactory> WithTags(this SdiSourceFactory parentFactory, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerSdiSourceTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SdiSourceFactory, T1, InnerSdiSourceTagsFactory> WithTags<T1>(this CombinedResult<SdiSourceFactory, T1> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SdiSourceFactory, InnerSdiSourceTagsFactory> WithTags<T1>(this CombinedResult<T1, SdiSourceFactory> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SdiSourceFactory, T1, T2, InnerSdiSourceTagsFactory> WithTags<T1, T2>(this CombinedResult<SdiSourceFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SdiSourceFactory, T2, InnerSdiSourceTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, SdiSourceFactory, T2> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SdiSourceFactory, InnerSdiSourceTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, SdiSourceFactory> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SdiSourceFactory, T1, T2, T3, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<SdiSourceFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SdiSourceFactory, T2, T3, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, SdiSourceFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SdiSourceFactory, T3, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, SdiSourceFactory, T3> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SdiSourceFactory, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, SdiSourceFactory> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SdiSourceFactory, T1, T2, T3, T4, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<SdiSourceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SdiSourceFactory, T2, T3, T4, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, SdiSourceFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SdiSourceFactory, T3, T4, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, SdiSourceFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SdiSourceFactory, T4, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SdiSourceFactory, T4> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SdiSourceFactory, InnerSdiSourceTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SdiSourceFactory> combinedResult, Action<Humidifier.MediaLive.SdiSourceTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
