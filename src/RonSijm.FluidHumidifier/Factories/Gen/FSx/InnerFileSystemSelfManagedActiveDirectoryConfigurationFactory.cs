// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerFileSystemSelfManagedActiveDirectoryConfigurationFactory(Action<Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration>
{

    protected override Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration Create()
    {
        var selfManagedActiveDirectoryConfigurationResult = CreateSelfManagedActiveDirectoryConfiguration();
        factoryAction?.Invoke(selfManagedActiveDirectoryConfigurationResult);

        return selfManagedActiveDirectoryConfigurationResult;
    }

    private Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration CreateSelfManagedActiveDirectoryConfiguration()
    {
        var selfManagedActiveDirectoryConfigurationResult = new Humidifier.FSx.FileSystemTypes.SelfManagedActiveDirectoryConfiguration();

        return selfManagedActiveDirectoryConfigurationResult;
    }

} // End Of Class

public static class InnerFileSystemSelfManagedActiveDirectoryConfigurationFactoryExtensions
{
}
