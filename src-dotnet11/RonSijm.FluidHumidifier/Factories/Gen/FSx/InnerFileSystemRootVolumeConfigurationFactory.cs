// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemRootVolumeConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration Create()
    {
        var rootVolumeConfigurationResult = CreateRootVolumeConfiguration();
        factoryAction?.Invoke(rootVolumeConfigurationResult);

        return rootVolumeConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration CreateRootVolumeConfiguration()
    {
        var rootVolumeConfigurationResult = new Humidifier.FSx.FileSystemTypes.RootVolumeConfiguration();

        return rootVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemRootVolumeConfigurationFactoryExtensions
{
}
