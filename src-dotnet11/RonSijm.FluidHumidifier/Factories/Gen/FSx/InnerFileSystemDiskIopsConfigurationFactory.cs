// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemDiskIopsConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration Create()
    {
        var diskIopsConfigurationResult = CreateDiskIopsConfiguration();
        factoryAction?.Invoke(diskIopsConfigurationResult);

        return diskIopsConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration CreateDiskIopsConfiguration()
    {
        var diskIopsConfigurationResult = new Humidifier.FSx.FileSystemTypes.DiskIopsConfiguration();

        return diskIopsConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemDiskIopsConfigurationFactoryExtensions
{
}
