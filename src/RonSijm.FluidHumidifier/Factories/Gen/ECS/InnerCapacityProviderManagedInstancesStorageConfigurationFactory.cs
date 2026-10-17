// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderManagedInstancesStorageConfigurationFactory(Action<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration>
{

    protected override Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration Create()
    {
        var managedInstancesStorageConfigurationResult = CreateManagedInstancesStorageConfiguration();
        factoryAction?.Invoke(managedInstancesStorageConfigurationResult);

        return managedInstancesStorageConfigurationResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration CreateManagedInstancesStorageConfiguration()
    {
        var managedInstancesStorageConfigurationResult = new Humidifier.ECS.CapacityProviderTypes.ManagedInstancesStorageConfiguration();

        return managedInstancesStorageConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderManagedInstancesStorageConfigurationFactoryExtensions
{
}
