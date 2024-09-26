// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FSx;

public class InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactory(Action<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration>
{

    protected override Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration Create()
    {
        var selfManagedActiveDirectoryConfigurationResult = CreateSelfManagedActiveDirectoryConfiguration();
        factoryAction?.Invoke(selfManagedActiveDirectoryConfigurationResult);

        return selfManagedActiveDirectoryConfigurationResult;
    }

    private Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration CreateSelfManagedActiveDirectoryConfiguration()
    {
        var selfManagedActiveDirectoryConfigurationResult = new Humidifier.FSx.StorageVirtualMachineTypes.SelfManagedActiveDirectoryConfiguration();

        return selfManagedActiveDirectoryConfigurationResult;
    }

} // End Of Class

public static class InnerStorageVirtualMachineSelfManagedActiveDirectoryConfigurationFactoryExtensions
{
}
