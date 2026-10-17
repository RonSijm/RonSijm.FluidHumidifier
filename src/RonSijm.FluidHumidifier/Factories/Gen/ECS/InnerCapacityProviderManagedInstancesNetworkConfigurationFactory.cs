// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECS;

public class InnerCapacityProviderManagedInstancesNetworkConfigurationFactory(Action<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration>
{

    protected override Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration Create()
    {
        var managedInstancesNetworkConfigurationResult = CreateManagedInstancesNetworkConfiguration();
        factoryAction?.Invoke(managedInstancesNetworkConfigurationResult);

        return managedInstancesNetworkConfigurationResult;
    }

    private Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration CreateManagedInstancesNetworkConfiguration()
    {
        var managedInstancesNetworkConfigurationResult = new Humidifier.ECS.CapacityProviderTypes.ManagedInstancesNetworkConfiguration();

        return managedInstancesNetworkConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderManagedInstancesNetworkConfigurationFactoryExtensions
{
}
