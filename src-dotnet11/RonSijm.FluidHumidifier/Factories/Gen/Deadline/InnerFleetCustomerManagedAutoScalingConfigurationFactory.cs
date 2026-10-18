// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetCustomerManagedAutoScalingConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration>
{

    protected override Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration Create()
    {
        var customerManagedAutoScalingConfigurationResult = CreateCustomerManagedAutoScalingConfiguration();
        factoryAction?.Invoke(customerManagedAutoScalingConfigurationResult);

        return customerManagedAutoScalingConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration CreateCustomerManagedAutoScalingConfiguration()
    {
        var customerManagedAutoScalingConfigurationResult = new Humidifier.Deadline.FleetTypes.CustomerManagedAutoScalingConfiguration();

        return customerManagedAutoScalingConfigurationResult;
    }

} // End Of Class

public static class InnerFleetCustomerManagedAutoScalingConfigurationFactoryExtensions
{
}
