// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationSMBMountOptionsFactory(Action<Humidifier.DataSync.LocationSMBTypes.MountOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationSMBTypes.MountOptions>
{

    protected override Humidifier.DataSync.LocationSMBTypes.MountOptions Create()
    {
        var mountOptionsResult = CreateMountOptions();
        factoryAction?.Invoke(mountOptionsResult);

        return mountOptionsResult;
    }

    private Humidifier.DataSync.LocationSMBTypes.MountOptions CreateMountOptions()
    {
        var mountOptionsResult = new Humidifier.DataSync.LocationSMBTypes.MountOptions();

        return mountOptionsResult;
    }

} // End Of Class

public static class InnerLocationSMBMountOptionsFactoryExtensions
{
}
