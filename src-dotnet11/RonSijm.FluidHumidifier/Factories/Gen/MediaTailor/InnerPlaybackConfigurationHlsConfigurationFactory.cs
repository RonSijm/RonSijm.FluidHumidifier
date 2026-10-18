// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationHlsConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration Create()
    {
        var hlsConfigurationResult = CreateHlsConfiguration();
        factoryAction?.Invoke(hlsConfigurationResult);

        return hlsConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration CreateHlsConfiguration()
    {
        var hlsConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.HlsConfiguration();

        return hlsConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationHlsConfigurationFactoryExtensions
{
}
