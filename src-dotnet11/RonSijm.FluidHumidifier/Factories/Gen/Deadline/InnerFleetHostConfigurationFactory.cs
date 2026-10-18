// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerFleetHostConfigurationFactory(Action<Humidifier.Deadline.FleetTypes.HostConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.FleetTypes.HostConfiguration>
{

    protected override Humidifier.Deadline.FleetTypes.HostConfiguration Create()
    {
        var hostConfigurationResult = CreateHostConfiguration();
        factoryAction?.Invoke(hostConfigurationResult);

        return hostConfigurationResult;
    }

    private Humidifier.Deadline.FleetTypes.HostConfiguration CreateHostConfiguration()
    {
        var hostConfigurationResult = new Humidifier.Deadline.FleetTypes.HostConfiguration();

        return hostConfigurationResult;
    }

} // End Of Class

public static class InnerFleetHostConfigurationFactoryExtensions
{
}
