// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetServiceManagedEc2AutoScalingConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration>
{

    protected override Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration Create()
    {
        var serviceManagedEc2AutoScalingConfigurationResult = CreateServiceManagedEc2AutoScalingConfiguration();
        factoryAction?.Invoke(serviceManagedEc2AutoScalingConfigurationResult);

        return serviceManagedEc2AutoScalingConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration CreateServiceManagedEc2AutoScalingConfiguration()
    {
        var serviceManagedEc2AutoScalingConfigurationResult = new Humidifier.Deadline.FleetTypes.ServiceManagedEc2AutoScalingConfiguration();

        return serviceManagedEc2AutoScalingConfigurationResult;
    }

} // End Of Class

public static class InnerFleetServiceManagedEc2AutoScalingConfigurationFactoryExtensions
{
}
