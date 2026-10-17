// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAdsPersonalizationTimeoutsFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts Create()
    {
        var adsPersonalizationTimeoutsResult = CreateAdsPersonalizationTimeouts();
        factoryAction?.Invoke(adsPersonalizationTimeoutsResult);

        return adsPersonalizationTimeoutsResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts CreateAdsPersonalizationTimeouts()
    {
        var adsPersonalizationTimeoutsResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationTimeouts();

        return adsPersonalizationTimeoutsResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAdsPersonalizationTimeoutsFactoryExtensions
{
}
