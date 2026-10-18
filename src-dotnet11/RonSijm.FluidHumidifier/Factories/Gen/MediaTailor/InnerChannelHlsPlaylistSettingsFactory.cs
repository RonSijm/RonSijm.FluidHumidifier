// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelHlsPlaylistSettingsFactory(Action<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings>
{

    protected override Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings Create()
    {
        var hlsPlaylistSettingsResult = CreateHlsPlaylistSettings();
        factoryAction?.Invoke(hlsPlaylistSettingsResult);

        return hlsPlaylistSettingsResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings CreateHlsPlaylistSettings()
    {
        var hlsPlaylistSettingsResult = new Humidifier.MediaTailor.ChannelTypes.HlsPlaylistSettings();

        return hlsPlaylistSettingsResult;
    }

} // End Of Class

public static class InnerChannelHlsPlaylistSettingsFactoryExtensions
{
}
