// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationLivePreRollConfigurationFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration Create()
    {
        var livePreRollConfigurationResult = CreateLivePreRollConfiguration();
        factoryAction?.Invoke(livePreRollConfigurationResult);

        return livePreRollConfigurationResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration CreateLivePreRollConfiguration()
    {
        var livePreRollConfigurationResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.LivePreRollConfiguration();

        return livePreRollConfigurationResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationLivePreRollConfigurationFactoryExtensions
{
}
