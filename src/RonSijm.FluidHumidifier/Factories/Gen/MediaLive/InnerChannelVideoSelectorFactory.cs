// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVideoSelectorFactory(Action<Humidifier.MediaLive.ChannelTypes.VideoSelector> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VideoSelector>
{

    internal InnerChannelVideoSelectorColorSpaceSettingsFactory ColorSpaceSettingsFactory { get; set; }

    internal InnerChannelVideoSelectorSettingsFactory SelectorSettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.VideoSelector Create()
    {
        var videoSelectorResult = CreateVideoSelector();
        factoryAction?.Invoke(videoSelectorResult);

        return videoSelectorResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VideoSelector CreateVideoSelector()
    {
        var videoSelectorResult = new Humidifier.MediaLive.ChannelTypes.VideoSelector();

        return videoSelectorResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.VideoSelector result)
    {
        base.CreateChildren(result);

        result.ColorSpaceSettings ??= ColorSpaceSettingsFactory?.Build();
        result.SelectorSettings ??= SelectorSettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelVideoSelectorFactoryExtensions
{
    public static CombinedResult<InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings(this InnerChannelVideoSelectorFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null)
    {
        parentFactory.ColorSpaceSettingsFactory = new InnerChannelVideoSelectorColorSpaceSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ColorSpaceSettingsFactory);
    }

    public static CombinedResult<InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings(this InnerChannelVideoSelectorFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null)
    {
        parentFactory.SelectorSettingsFactory = new InnerChannelVideoSelectorSettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SelectorSettingsFactory);
    }

    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1>(this CombinedResult<InnerChannelVideoSelectorFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1>(this CombinedResult<T1, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorColorSpaceSettingsFactory> WithColorSpaceSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithColorSpaceSettings(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1>(this CombinedResult<InnerChannelVideoSelectorFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectorSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1>(this CombinedResult<T1, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, WithSelectorSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3, T4>(this CombinedResult<InnerChannelVideoSelectorFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelVideoSelectorFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, T4, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelVideoSelectorFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, T4, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorFactory, InnerChannelVideoSelectorSettingsFactory> WithSelectorSettings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSelectorSettings(combinedResult.T5, subFactoryAction));
}
