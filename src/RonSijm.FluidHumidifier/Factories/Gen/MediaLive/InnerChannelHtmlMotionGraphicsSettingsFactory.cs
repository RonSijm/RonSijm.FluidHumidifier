// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelHtmlMotionGraphicsSettingsFactory(Action<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings>
{

    protected override Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings Create()
    {
        var htmlMotionGraphicsSettingsResult = CreateHtmlMotionGraphicsSettings();
        factoryAction?.Invoke(htmlMotionGraphicsSettingsResult);

        return htmlMotionGraphicsSettingsResult;
    }

    private Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings CreateHtmlMotionGraphicsSettings()
    {
        var htmlMotionGraphicsSettingsResult = new Humidifier.MediaLive.ChannelTypes.HtmlMotionGraphicsSettings();

        return htmlMotionGraphicsSettingsResult;
    }

} // End Of Class

public static class InnerChannelHtmlMotionGraphicsSettingsFactoryExtensions
{
}
