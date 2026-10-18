// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelPrimaryChannelSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings Create()
    {
        var primaryChannelSettingsResult = CreatePrimaryChannelSettings();
        factoryAction?.Invoke(primaryChannelSettingsResult);

        return primaryChannelSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings CreatePrimaryChannelSettings()
    {
        var primaryChannelSettingsResult = new Humidifier.MediaLive.ChannelTypes.PrimaryChannelSettings();

        return primaryChannelSettingsResult;
    }

} // End Of Class

public static class InnerChannelPrimaryChannelSettingsFactoryExtensions
{
}
