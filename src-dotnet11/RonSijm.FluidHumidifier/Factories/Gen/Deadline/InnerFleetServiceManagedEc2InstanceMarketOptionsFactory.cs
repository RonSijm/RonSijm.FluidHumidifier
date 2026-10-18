// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetServiceManagedEc2InstanceMarketOptionsFactory(Action<Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions>
{

    protected override Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions Create()
    {
        var serviceManagedEc2InstanceMarketOptionsResult = CreateServiceManagedEc2InstanceMarketOptions();
        factoryAction?.Invoke(serviceManagedEc2InstanceMarketOptionsResult);

        return serviceManagedEc2InstanceMarketOptionsResult;
    }

    private Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions CreateServiceManagedEc2InstanceMarketOptions()
    {
        var serviceManagedEc2InstanceMarketOptionsResult = new Humidifier.Deadline.FleetTypes.ServiceManagedEc2InstanceMarketOptions();

        return serviceManagedEc2InstanceMarketOptionsResult;
    }

} // End Of Class

public static class InnerFleetServiceManagedEc2InstanceMarketOptionsFactoryExtensions
{
}
