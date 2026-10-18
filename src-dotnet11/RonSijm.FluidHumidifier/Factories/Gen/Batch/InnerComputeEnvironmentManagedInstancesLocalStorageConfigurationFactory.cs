// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentManagedInstancesLocalStorageConfigurationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration Create()
    {
        var managedInstancesLocalStorageConfigurationResult = CreateManagedInstancesLocalStorageConfiguration();
        factoryAction?.Invoke(managedInstancesLocalStorageConfigurationResult);

        return managedInstancesLocalStorageConfigurationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration CreateManagedInstancesLocalStorageConfiguration()
    {
        var managedInstancesLocalStorageConfigurationResult = new Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesLocalStorageConfiguration();

        return managedInstancesLocalStorageConfigurationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentManagedInstancesLocalStorageConfigurationFactoryExtensions
{
}
