// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerFleetVolumeConfigFactory(Action<Humidifier.AppStream.FleetTypes.VolumeConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.FleetTypes.VolumeConfig>
{

    protected override Humidifier.AppStream.FleetTypes.VolumeConfig Create()
    {
        var volumeConfigResult = CreateVolumeConfig();
        factoryAction?.Invoke(volumeConfigResult);

        return volumeConfigResult;
    }

    private Humidifier.AppStream.FleetTypes.VolumeConfig CreateVolumeConfig()
    {
        var volumeConfigResult = new Humidifier.AppStream.FleetTypes.VolumeConfig();

        return volumeConfigResult;
    }

} // End Of Class

public static class InnerFleetVolumeConfigFactoryExtensions
{
}
