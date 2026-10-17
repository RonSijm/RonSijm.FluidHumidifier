// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerContainerFleetManagedCapacityConfigurationFactory(Action<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration>
{

    protected override Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration Create()
    {
        var managedCapacityConfigurationResult = CreateManagedCapacityConfiguration();
        factoryAction?.Invoke(managedCapacityConfigurationResult);

        return managedCapacityConfigurationResult;
    }

    private Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration CreateManagedCapacityConfiguration()
    {
        var managedCapacityConfigurationResult = new Humidifier.GameLift.ContainerFleetTypes.ManagedCapacityConfiguration();

        return managedCapacityConfigurationResult;
    }

} // End Of Class

public static class InnerContainerFleetManagedCapacityConfigurationFactoryExtensions
{
}
