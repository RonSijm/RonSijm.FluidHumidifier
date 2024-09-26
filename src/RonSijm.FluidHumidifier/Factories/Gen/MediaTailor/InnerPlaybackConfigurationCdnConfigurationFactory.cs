// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationCdnConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration Create()
    {
        var cdnConfigurationResult = CreateCdnConfiguration();
        factoryAction?.Invoke(cdnConfigurationResult);

        return cdnConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration CreateCdnConfiguration()
    {
        var cdnConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.CdnConfiguration();

        return cdnConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationCdnConfigurationFactoryExtensions
{
}
