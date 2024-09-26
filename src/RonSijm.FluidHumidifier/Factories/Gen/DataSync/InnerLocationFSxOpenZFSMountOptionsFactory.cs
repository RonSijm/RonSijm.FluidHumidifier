// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationFSxOpenZFSMountOptionsFactory(Action<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions>
{

    protected override Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions Create()
    {
        var mountOptionsResult = CreateMountOptions();
        factoryAction?.Invoke(mountOptionsResult);

        return mountOptionsResult;
    }

    private Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions CreateMountOptions()
    {
        var mountOptionsResult = new Humidifier.DataSync.LocationFSxOpenZFSTypes.MountOptions();

        return mountOptionsResult;
    }

} // End Of Class

public static class InnerLocationFSxOpenZFSMountOptionsFactoryExtensions
{
}
