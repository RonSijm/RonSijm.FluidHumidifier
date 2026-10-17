// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Batch;

public class InnerComputeEnvironmentManagedInstancesNetworkConfigurationFactory(Action<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration>
{

    protected override Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration Create()
    {
        var managedInstancesNetworkConfigurationResult = CreateManagedInstancesNetworkConfiguration();
        factoryAction?.Invoke(managedInstancesNetworkConfigurationResult);

        return managedInstancesNetworkConfigurationResult;
    }

    private Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration CreateManagedInstancesNetworkConfiguration()
    {
        var managedInstancesNetworkConfigurationResult = new Humidifier.Batch.ComputeEnvironmentTypes.ManagedInstancesNetworkConfiguration();

        return managedInstancesNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerComputeEnvironmentManagedInstancesNetworkConfigurationFactoryExtensions
{
}
