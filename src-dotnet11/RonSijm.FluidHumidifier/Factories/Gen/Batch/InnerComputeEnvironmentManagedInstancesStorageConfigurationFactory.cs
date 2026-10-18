// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentManagedInstancesStorageConfigurationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration Create()
    {
        var managedInstancesStorageConfigurationResult = CreateManagedInstancesStorageConfiguration();
        factoryAction?.Invoke(managedInstancesStorageConfigurationResult);

        return managedInstancesStorageConfigurationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration CreateManagedInstancesStorageConfiguration()
    {
        var managedInstancesStorageConfigurationResult = new Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesStorageConfiguration();

        return managedInstancesStorageConfigurationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentManagedInstancesStorageConfigurationFactoryExtensions
{
}
