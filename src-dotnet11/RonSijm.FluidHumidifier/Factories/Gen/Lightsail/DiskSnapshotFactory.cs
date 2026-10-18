// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Lightsail;

public class DiskSnapshotFactory(string resourceName = null, Action<Humidifier.Lightsail.DiskSnapshot> factoryAction = null) : ResourceFactory<Humidifier.Lightsail.DiskSnapshot>(resourceName)
{

    protected override Humidifier.Lightsail.DiskSnapshot Create()
    {
        var diskSnapshotResult = CreateDiskSnapshot();
        factoryAction?.Invoke(diskSnapshotResult);

        return diskSnapshotResult;
    }

    private Humidifier.Lightsail.DiskSnapshot CreateDiskSnapshot()
    {
        var diskSnapshotResult = new Humidifier.Lightsail.DiskSnapshot
        {
            GivenName = InputResourceName,
        };

        return diskSnapshotResult;
    }

} // End Of Class

public static class DiskSnapshotFactoryExtensions
{
}
