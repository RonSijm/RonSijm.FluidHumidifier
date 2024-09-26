// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NimbleStudio;

public class InnerLaunchProfileVolumeConfigurationFactory(Action<Humidifier.NimbleStudio.LaunchProfileTypes.VolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.NimbleStudio.LaunchProfileTypes.VolumeConfiguration>
{

    protected override Humidifier.NimbleStudio.LaunchProfileTypes.VolumeConfiguration Create()
    {
        var volumeConfigurationResult = CreateVolumeConfiguration();
        factoryAction?.Invoke(volumeConfigurationResult);

        return volumeConfigurationResult;
    }

    private Humidifier.NimbleStudio.LaunchProfileTypes.VolumeConfiguration CreateVolumeConfiguration()
    {
        var volumeConfigurationResult = new Humidifier.NimbleStudio.LaunchProfileTypes.VolumeConfiguration();

        return volumeConfigurationResult;
    }

} // End Of Class

public static class InnerLaunchProfileVolumeConfigurationFactoryExtensions
{
}
