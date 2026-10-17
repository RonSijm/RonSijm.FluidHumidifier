// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelChannelEngineVersionRequestFactory(Action<Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest>
{

    protected override Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest Create()
    {
        var channelEngineVersionRequestResult = CreateChannelEngineVersionRequest();
        factoryAction?.Invoke(channelEngineVersionRequestResult);

        return channelEngineVersionRequestResult;
    }

    private Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest CreateChannelEngineVersionRequest()
    {
        var channelEngineVersionRequestResult = new Humidifier.MediaLive.ChannelTypes.ChannelEngineVersionRequest();

        return channelEngineVersionRequestResult;
    }

} // End Of Class

public static class InnerChannelChannelEngineVersionRequestFactoryExtensions
{
}
