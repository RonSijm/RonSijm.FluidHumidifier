// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class ChannelPlacementGroupFactory(string resourceName = null, Action<Humidifier.MediaLive.ChannelPlacementGroup> factoryAction = null) : ResourceFactory<Humidifier.MediaLive.ChannelPlacementGroup>(resourceName)
{

    internal List<InnerChannelPlacementGroupTagsFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.MediaLive.ChannelPlacementGroup Create()
    {
        var channelPlacementGroupResult = CreateChannelPlacementGroup();
        factoryAction?.Invoke(channelPlacementGroupResult);

        return channelPlacementGroupResult;
    }

    private Humidifier.MediaLive.ChannelPlacementGroup CreateChannelPlacementGroup()
    {
        var channelPlacementGroupResult = new Humidifier.MediaLive.ChannelPlacementGroup
        {
            GivenName = InputResourceName,
        };

        return channelPlacementGroupResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelPlacementGroup result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ChannelPlacementGroupFactoryExtensions
{
    public static CombinedResult<ChannelPlacementGroupFactory, InnerChannelPlacementGroupTagsFactory> WithTags(this ChannelPlacementGroupFactory parentFactory, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null)
    {
        var factory = new InnerChannelPlacementGroupTagsFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ChannelPlacementGroupFactory, T1, InnerChannelPlacementGroupTagsFactory> WithTags<T1>(this CombinedResult<ChannelPlacementGroupFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelPlacementGroupFactory, InnerChannelPlacementGroupTagsFactory> WithTags<T1>(this CombinedResult<T1, ChannelPlacementGroupFactory> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ChannelPlacementGroupFactory, T1, T2, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2>(this CombinedResult<ChannelPlacementGroupFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelPlacementGroupFactory, T2, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, ChannelPlacementGroupFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelPlacementGroupFactory, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, ChannelPlacementGroupFactory> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ChannelPlacementGroupFactory, T1, T2, T3, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<ChannelPlacementGroupFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelPlacementGroupFactory, T2, T3, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, ChannelPlacementGroupFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelPlacementGroupFactory, T3, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, ChannelPlacementGroupFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelPlacementGroupFactory, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, ChannelPlacementGroupFactory> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ChannelPlacementGroupFactory, T1, T2, T3, T4, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<ChannelPlacementGroupFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ChannelPlacementGroupFactory, T2, T3, T4, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, ChannelPlacementGroupFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ChannelPlacementGroupFactory, T3, T4, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, ChannelPlacementGroupFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ChannelPlacementGroupFactory, T4, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ChannelPlacementGroupFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ChannelPlacementGroupFactory, InnerChannelPlacementGroupTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ChannelPlacementGroupFactory> combinedResult, Action<Humidifier.MediaLive.ChannelPlacementGroupTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
