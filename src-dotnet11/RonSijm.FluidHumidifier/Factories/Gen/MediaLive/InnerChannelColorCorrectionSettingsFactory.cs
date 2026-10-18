// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelColorCorrectionSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings Create()
    {
        var colorCorrectionSettingsResult = CreateColorCorrectionSettings();
        factoryAction?.Invoke(colorCorrectionSettingsResult);

        return colorCorrectionSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings CreateColorCorrectionSettings()
    {
        var colorCorrectionSettingsResult = new Humidifier.MediaLive.ChannelTypes.ColorCorrectionSettings();

        return colorCorrectionSettingsResult;
    }

} // End Of Class

public static class InnerChannelColorCorrectionSettingsFactoryExtensions
{
}
