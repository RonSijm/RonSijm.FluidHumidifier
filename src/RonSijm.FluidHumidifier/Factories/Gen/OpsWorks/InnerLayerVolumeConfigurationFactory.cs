// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.OpsWorks;

public class InnerLayerVolumeConfigurationFactory(Action<Humidifier.OpsWorks.LayerTypes.VolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.OpsWorks.LayerTypes.VolumeConfiguration>
{

    protected override Humidifier.OpsWorks.LayerTypes.VolumeConfiguration Create()
    {
        var volumeConfigurationResult = CreateVolumeConfiguration();
        factoryAction?.Invoke(volumeConfigurationResult);

        return volumeConfigurationResult;
    }

    private Humidifier.OpsWorks.LayerTypes.VolumeConfiguration CreateVolumeConfiguration()
    {
        var volumeConfigurationResult = new Humidifier.OpsWorks.LayerTypes.VolumeConfiguration();

        return volumeConfigurationResult;
    }

} // End Of Class

public static class InnerLayerVolumeConfigurationFactoryExtensions
{
}
