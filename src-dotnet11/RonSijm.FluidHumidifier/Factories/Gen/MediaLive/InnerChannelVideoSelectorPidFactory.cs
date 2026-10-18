// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVideoSelectorPidFactory(Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VideoSelectorPid>
{

    protected override Humidifier.MediaLive.ChannelTypes.VideoSelectorPid Create()
    {
        var videoSelectorPidResult = CreateVideoSelectorPid();
        factoryAction?.Invoke(videoSelectorPidResult);

        return videoSelectorPidResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VideoSelectorPid CreateVideoSelectorPid()
    {
        var videoSelectorPidResult = new Humidifier.MediaLive.ChannelTypes.VideoSelectorPid();

        return videoSelectorPidResult;
    }

} // End Of Class

public static class InnerChannelVideoSelectorPidFactoryExtensions
{
}
