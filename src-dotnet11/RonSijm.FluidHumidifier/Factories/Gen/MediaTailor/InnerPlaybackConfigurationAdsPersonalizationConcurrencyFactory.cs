// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAdsPersonalizationConcurrencyFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency Create()
    {
        var adsPersonalizationConcurrencyResult = CreateAdsPersonalizationConcurrency();
        factoryAction?.Invoke(adsPersonalizationConcurrencyResult);

        return adsPersonalizationConcurrencyResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency CreateAdsPersonalizationConcurrency()
    {
        var adsPersonalizationConcurrencyResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AdsPersonalizationConcurrency();

        return adsPersonalizationConcurrencyResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAdsPersonalizationConcurrencyFactoryExtensions
{
}
