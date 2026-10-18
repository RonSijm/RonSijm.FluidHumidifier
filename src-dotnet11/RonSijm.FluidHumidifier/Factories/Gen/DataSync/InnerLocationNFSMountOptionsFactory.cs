// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataSync;

public class InnerLocationNFSMountOptionsFactory(Action<Humidifier.DataSync.LocationNFSTypes.MountOptions> factoryAction = null) : SubResourceFactory<Humidifier.DataSync.LocationNFSTypes.MountOptions>
{

    protected override Humidifier.DataSync.LocationNFSTypes.MountOptions Create()
    {
        var mountOptionsResult = CreateMountOptions();
        factoryAction?.Invoke(mountOptionsResult);

        return mountOptionsResult;
    }

    private Humidifier.DataSync.LocationNFSTypes.MountOptions CreateMountOptions()
    {
        var mountOptionsResult = new Humidifier.DataSync.LocationNFSTypes.MountOptions();

        return mountOptionsResult;
    }

} // End Of Class

public static class InnerLocationNFSMountOptionsFactoryExtensions
{
}
