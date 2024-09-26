// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVideoSelectorSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings>
{

    internal InnerChannelVideoSelectorProgramIdFactory VideoSelectorProgramIdFactory { get; set; }

    internal InnerChannelVideoSelectorPidFactory VideoSelectorPidFactory { get; set; }

    protected override Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings Create()
    {
        var videoSelectorSettingsResult = CreateVideoSelectorSettings();
        factoryAction?.Invoke(videoSelectorSettingsResult);

        return videoSelectorSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings CreateVideoSelectorSettings()
    {
        var videoSelectorSettingsResult = new Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings();

        return videoSelectorSettingsResult;
    }
    public override void CreateChildren(Humidifier.MediaLive.ChannelTypes.VideoSelectorSettings result)
    {
        base.CreateChildren(result);

        result.VideoSelectorProgramId ??= VideoSelectorProgramIdFactory?.Build();
        result.VideoSelectorPid ??= VideoSelectorPidFactory?.Build();
    }

} // End Of Class

public static class InnerChannelVideoSelectorSettingsFactoryExtensions
{
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId(this InnerChannelVideoSelectorSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null)
    {
        parentFactory.VideoSelectorProgramIdFactory = new InnerChannelVideoSelectorProgramIdFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VideoSelectorProgramIdFactory);
    }

    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid(this InnerChannelVideoSelectorSettingsFactory parentFactory, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null)
    {
        parentFactory.VideoSelectorPidFactory = new InnerChannelVideoSelectorPidFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VideoSelectorPidFactory);
    }

    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, T4, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3, T4>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, T4, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, T4, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, T4, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorProgramIdFactory> WithVideoSelectorProgramId<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorProgramId(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, T4, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3, T4>(this CombinedResult<InnerChannelVideoSelectorSettingsFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, T4, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3, T4>(this CombinedResult<T1, InnerChannelVideoSelectorSettingsFactory, T2, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, T4, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerChannelVideoSelectorSettingsFactory, T3, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, T4, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerChannelVideoSelectorSettingsFactory, T4> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory, InnerChannelVideoSelectorPidFactory> WithVideoSelectorPid<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerChannelVideoSelectorSettingsFactory> combinedResult, Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVideoSelectorPid(combinedResult.T5, subFactoryAction));
}
