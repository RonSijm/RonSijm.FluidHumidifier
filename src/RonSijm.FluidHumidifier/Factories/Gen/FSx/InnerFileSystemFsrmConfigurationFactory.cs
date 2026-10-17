// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemFsrmConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.FsrmConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.FsrmConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.FsrmConfiguration Create()
    {
        var fsrmConfigurationResult = CreateFsrmConfiguration();
        factoryAction?.Invoke(fsrmConfigurationResult);

        return fsrmConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.FsrmConfiguration CreateFsrmConfiguration()
    {
        var fsrmConfigurationResult = new Humidifier.FSx.FileSystemTypes.FsrmConfiguration();

        return fsrmConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemFsrmConfigurationFactoryExtensions
{
}
