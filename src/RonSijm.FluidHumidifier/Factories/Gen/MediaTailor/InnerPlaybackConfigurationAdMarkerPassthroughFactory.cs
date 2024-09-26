// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaTailor;

public class InnerPlaybackConfigurationAdMarkerPassthroughFactory(Action<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough> factoryAction = null) : SubResourceFactory<Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough>
{

    protected override Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough Create()
    {
        var adMarkerPassthroughResult = CreateAdMarkerPassthrough();
        factoryAction?.Invoke(adMarkerPassthroughResult);

        return adMarkerPassthroughResult;
    }

    private Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough CreateAdMarkerPassthrough()
    {
        var adMarkerPassthroughResult = new Humidifier.MediaTailor.PlaybackConfigurationTypes.AdMarkerPassthrough();

        return adMarkerPassthroughResult;
    }

} // End Of Class

public static class InnerPlaybackConfigurationAdMarkerPassthroughFactoryExtensions
{
}
