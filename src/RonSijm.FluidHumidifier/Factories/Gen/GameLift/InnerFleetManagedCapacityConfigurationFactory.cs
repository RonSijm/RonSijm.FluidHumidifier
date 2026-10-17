// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GameLift;

public class InnerFleetManagedCapacityConfigurationFactory(Action<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration>
{

    protected override Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration Create()
    {
        var managedCapacityConfigurationResult = CreateManagedCapacityConfiguration();
        factoryAction?.Invoke(managedCapacityConfigurationResult);

        return managedCapacityConfigurationResult;
    }

    private Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration CreateManagedCapacityConfiguration()
    {
        var managedCapacityConfigurationResult = new Humidifier.GameLift.FleetTypes.ManagedCapacityConfiguration();

        return managedCapacityConfigurationResult;
    }

} // End Of Class

public static class InnerFleetManagedCapacityConfigurationFactoryExtensions
{
}
