// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaLive;

public class InnerChannelThumbnailConfigurationFactory(Action<Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration>
{

    protected override Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration Create()
    {
        var thumbnailConfigurationResult = CreateThumbnailConfiguration();
        factoryAction?.Invoke(thumbnailConfigurationResult);

        return thumbnailConfigurationResult;
    }

    private Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration CreateThumbnailConfiguration()
    {
        var thumbnailConfigurationResult = new Humidifier.MediaLive.ChannelTypes.ThumbnailConfiguration();

        return thumbnailConfigurationResult;
    }

} // End Of Class

public static class InnerChannelThumbnailConfigurationFactoryExtensions
{
}
