// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MediaConnect;

public class InnerRouterInputSilentAudioConfigurationFactory(Action<Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration>
{

    protected override Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration Create()
    {
        var silentAudioConfigurationResult = CreateSilentAudioConfiguration();
        factoryAction?.Invoke(silentAudioConfigurationResult);

        return silentAudioConfigurationResult;
    }

    private Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration CreateSilentAudioConfiguration()
    {
        var silentAudioConfigurationResult = new Humidifier.MediaConnect.RouterInputTypes.SilentAudioConfiguration();

        return silentAudioConfigurationResult;
    }

} // End Of Class

public static class InnerRouterInputSilentAudioConfigurationFactoryExtensions
{
}
