// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupManagedStorageEncryptionConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration Create()
    {
        var managedStorageEncryptionConfigurationResult = CreateManagedStorageEncryptionConfiguration();
        factoryAction?.Invoke(managedStorageEncryptionConfigurationResult);

        return managedStorageEncryptionConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration CreateManagedStorageEncryptionConfiguration()
    {
        var managedStorageEncryptionConfigurationResult = new Humidifier.Athena.WorkGroupTypes.ManagedStorageEncryptionConfiguration();

        return managedStorageEncryptionConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupManagedStorageEncryptionConfigurationFactoryExtensions
{
}
