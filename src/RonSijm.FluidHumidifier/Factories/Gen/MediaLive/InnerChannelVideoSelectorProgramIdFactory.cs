// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelVideoSelectorProgramIdFactory(Action<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId>
{

    protected override Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId Create()
    {
        var videoSelectorProgramIdResult = CreateVideoSelectorProgramId();
        factoryAction?.Invoke(videoSelectorProgramIdResult);

        return videoSelectorProgramIdResult;
    }

    private Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId CreateVideoSelectorProgramId()
    {
        var videoSelectorProgramIdResult = new Humidifier.MediaLive.ChannelTypes.VideoSelectorProgramId();

        return videoSelectorProgramIdResult;
    }

} // End Of Class

public static class InnerChannelVideoSelectorProgramIdFactoryExtensions
{
}
