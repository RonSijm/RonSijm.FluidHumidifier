// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVideoSelectorColorSpaceSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings>
{

    internal InnerChannelHdr10SettingsFactory Hdr10SettingsFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings Create()
    {
        var videoSelectorColorSpaceSettingsResult = CreateVideoSelectorColorSpaceSettings();
        factoryAction?.Invoke(videoSelectorColorSpaceSettingsResult);

        return videoSelectorColorSpaceSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings CreateVideoSelectorColorSpaceSettings()
    {
        var videoSelectorColorSpaceSettingsResult = new Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings();

        return videoSelectorColorSpaceSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.VideoSelectorColorSpaceSettings result)
    {
        base.CreateChildren(result);

        result.Hdr10Settings ??= Hdr10SettingsFactory?.Build();
    }

} // End Of Class

public static class InnerChannelVideoSelectorColorSpaceSettingsFactoryExtensions
{
    public static CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, InnerChannelHdr10SettingsFactory> WithHdr10Settings(this InnerChannelVideoSelectorColorSpaceSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null)
    {
        parentFactory.Hdr10SettingsFactory = new InnerChannelHdr10SettingsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Hdr10SettingsFactory);
    }

    public static CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1>(this CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHdr10Settings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1>(this CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, WithHdr10Settings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2>(this CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2>(this CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2>(this CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2, T3, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3>(this CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2, T3, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3>(this CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory, T3, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2, T3, T4, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3, T4>(this CombinedResult<InnerChannelVideoSelectorColorSpaceSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2, T3, T4, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelVideoSelectorColorSpaceSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory, T3, T4, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelVideoSelectorColorSpaceSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory, T4, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorColorSpaceSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory, InnerChannelHdr10SettingsFactory> WithHdr10Settings<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorColorSpaceSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHdr10Settings(combinedResult.T5, subFactoryAction));
}
