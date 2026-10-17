// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationManifestServiceInteractionLogFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog Create()
    {
        var manifestServiceInteractionLogResult = CreateManifestServiceInteractionLog();
        factoryAction?.Invoke(manifestServiceInteractionLogResult);

        return manifestServiceInteractionLogResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog CreateManifestServiceInteractionLog()
    {
        var manifestServiceInteractionLogResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.ManifestServiceInteractionLog();

        return manifestServiceInteractionLogResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationManifestServiceInteractionLogFactoryExtensions
{
}
