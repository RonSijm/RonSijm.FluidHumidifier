// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelAnywhereSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.AnywhereSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.AnywhereSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.AnywhereSettings Create()
    {
        var anywhereSettingsResult = CreateAnywhereSettings();
        factoryAction?.Invoke(anywhereSettingsResult);

        return anywhereSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.AnywhereSettings CreateAnywhereSettings()
    {
        var anywhereSettingsResult = new Humidifier.MediaLive.ChannelTypes.AnywhereSettings();

        return anywhereSettingsResult;
    }

} // End Of Class

public static class InnerChannelAnywhereSettingsFactoryExtensions
{
}
