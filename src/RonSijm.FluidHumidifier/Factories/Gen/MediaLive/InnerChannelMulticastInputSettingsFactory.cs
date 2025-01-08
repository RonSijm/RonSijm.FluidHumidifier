// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelMulticastInputSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.MulticastInputSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.MulticastInputSettings Create()
    {
        var multicastInputSettingsResult = CreateMulticastInputSettings();
        factoryAction?.Invoke(multicastInputSettingsResult);

        return multicastInputSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.MulticastInputSettings CreateMulticastInputSettings()
    {
        var multicastInputSettingsResult = new Humidifier.MediaLive.ChannelTypes.MulticastInputSettings();

        return multicastInputSettingsResult;
    }

} // End Of Class

public static class InnerChannelMulticastInputSettingsFactoryExtensions
{
}
