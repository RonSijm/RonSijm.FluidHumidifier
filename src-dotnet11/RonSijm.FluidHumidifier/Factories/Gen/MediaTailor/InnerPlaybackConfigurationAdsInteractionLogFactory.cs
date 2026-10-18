// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAdsInteractionLogFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog Create()
    {
        var adsInteractionLogResult = CreateAdsInteractionLog();
        factoryAction?.Invoke(adsInteractionLogResult);

        return adsInteractionLogResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog CreateAdsInteractionLog()
    {
        var adsInteractionLogResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsInteractionLog();

        return adsInteractionLogResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAdsInteractionLogFactoryExtensions
{
}
