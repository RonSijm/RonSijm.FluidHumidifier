// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelHdr10SettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.Hdr10Settings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.Hdr10Settings>
{

    protected override Humidifier.MediaLive.ChannelTypes.Hdr10Settings Create()
    {
        var hdr10SettingsResult = CreateHdr10Settings();
        factoryAction?.Invoke(hdr10SettingsResult);

        return hdr10SettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.Hdr10Settings CreateHdr10Settings()
    {
        var hdr10SettingsResult = new Humidifier.MediaLive.ChannelTypes.Hdr10Settings();

        return hdr10SettingsResult;
    }

} // End Of Class

public static class InnerChannelHdr10SettingsFactoryExtensions
{
}
