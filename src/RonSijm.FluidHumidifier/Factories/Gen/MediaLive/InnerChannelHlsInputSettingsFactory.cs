// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelHlsInputSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.HlsInputSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.HlsInputSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.HlsInputSettings Create()
    {
        var hlsInputSettingsResult = CreateHlsInputSettings();
        factoryAction?.Invoke(hlsInputSettingsResult);

        return hlsInputSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.HlsInputSettings CreateHlsInputSettings()
    {
        var hlsInputSettingsResult = new Humidifier.MediaLive.ChannelTypes.HlsInputSettings();

        return hlsInputSettingsResult;
    }

} // End Of Class

public static class InnerChannelHlsInputSettingsFactoryExtensions
{
}
