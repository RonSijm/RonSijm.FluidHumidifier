// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.IVS;

public class InnerAdConfigurationMediaTailorPlaybackConfigurationFactory(Action<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration>
{

    protected override Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration Create()
    {
        var mediaTailorPlaybackConfigurationResult = CreateMediaTailorPlaybackConfiguration();
        factoryAction?.Invoke(mediaTailorPlaybackConfigurationResult);

        return mediaTailorPlaybackConfigurationResult;
    }

    private Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration CreateMediaTailorPlaybackConfiguration()
    {
        var mediaTailorPlaybackConfigurationResult = new Humidifier.IVS.AdConfigurationTypes.MediaTailorPlaybackConfiguration();

        return mediaTailorPlaybackConfigurationResult;
    }

} // End Of Class

public static class InnerAdConfigurationMediaTailorPlaybackConfigurationFactoryExtensions
{
}
