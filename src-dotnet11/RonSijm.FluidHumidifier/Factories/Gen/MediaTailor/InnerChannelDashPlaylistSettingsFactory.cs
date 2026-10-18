// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerChannelDashPlaylistSettingsFactory(Action<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings>
{

    protected override Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings Create()
    {
        var dashPlaylistSettingsResult = CreateDashPlaylistSettings();
        factoryAction?.Invoke(dashPlaylistSettingsResult);

        return dashPlaylistSettingsResult;
    }

    private Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings CreateDashPlaylistSettings()
    {
        var dashPlaylistSettingsResult = new Humidifier.MediaTailor.ChannelTypes.DashPlaylistSettings();

        return dashPlaylistSettingsResult;
    }

} // End Of Class

public static class InnerChannelDashPlaylistSettingsFactoryExtensions
{
}
