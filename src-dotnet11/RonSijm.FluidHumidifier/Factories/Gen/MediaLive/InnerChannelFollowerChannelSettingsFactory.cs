// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelFollowerChannelSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings Create()
    {
        var followerChannelSettingsResult = CreateFollowerChannelSettings();
        factoryAction?.Invoke(followerChannelSettingsResult);

        return followerChannelSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings CreateFollowerChannelSettings()
    {
        var followerChannelSettingsResult = new Humidifier.MediaLive.ChannelTypes.FollowerChannelSettings();

        return followerChannelSettingsResult;
    }

} // End Of Class

public static class InnerChannelFollowerChannelSettingsFactoryExtensions
{
}
