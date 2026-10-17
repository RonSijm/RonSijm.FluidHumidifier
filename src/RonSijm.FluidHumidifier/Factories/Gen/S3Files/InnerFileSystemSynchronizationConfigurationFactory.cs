// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3Files;

public class InnerFileSystemSynchronizationConfigurationFactory(Action<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration>
{

    protected override Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration Create()
    {
        var synchronizationConfigurationResult = CreateSynchronizationConfiguration();
        factoryAction?.Invoke(synchronizationConfigurationResult);

        return synchronizationConfigurationResult;
    }

    private Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration CreateSynchronizationConfiguration()
    {
        var synchronizationConfigurationResult = new Humidifier.S3Files.FileSystemTypes.SynchronizationConfiguration();

        return synchronizationConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemSynchronizationConfigurationFactoryExtensions
{
}
