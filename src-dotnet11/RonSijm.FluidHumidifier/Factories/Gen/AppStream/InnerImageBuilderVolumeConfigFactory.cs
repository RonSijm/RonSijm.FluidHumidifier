// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerImageBuilderVolumeConfigFactory(Action<Humidifier.AppStream.ImageBuilderTypes.VolumeConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.ImageBuilderTypes.VolumeConfig>
{

    protected override Humidifier.AppStream.ImageBuilderTypes.VolumeConfig Create()
    {
        var volumeConfigResult = CreateVolumeConfig();
        factoryAction?.Invoke(volumeConfigResult);

        return volumeConfigResult;
    }

    private Humidifier.AppStream.ImageBuilderTypes.VolumeConfig CreateVolumeConfig()
    {
        var volumeConfigResult = new Humidifier.AppStream.ImageBuilderTypes.VolumeConfig();

        return volumeConfigResult;
    }

} // End Of Class

public static class InnerImageBuilderVolumeConfigFactoryExtensions
{
}
