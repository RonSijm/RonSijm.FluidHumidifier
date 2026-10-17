// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderManagedInstancesLocalStorageConfigurationFactory(Action<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration>
{

    protected override Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration Create()
    {
        var managedInstancesLocalStorageConfigurationResult = CreateManagedInstancesLocalStorageConfiguration();
        factoryAction?.Invoke(managedInstancesLocalStorageConfigurationResult);

        return managedInstancesLocalStorageConfigurationResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration CreateManagedInstancesLocalStorageConfiguration()
    {
        var managedInstancesLocalStorageConfigurationResult = new Humidifier.ECS.CapacityProviderTypes.ManagedInstancesLocalStorageConfiguration();

        return managedInstancesLocalStorageConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderManagedInstancesLocalStorageConfigurationFactoryExtensions
{
}
