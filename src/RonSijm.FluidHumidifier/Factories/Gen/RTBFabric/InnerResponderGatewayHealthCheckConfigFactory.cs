// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerResponderGatewayHealthCheckConfigFactory(Action<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig>
{

    protected override Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig Create()
    {
        var healthCheckConfigResult = CreateHealthCheckConfig();
        factoryAction?.Invoke(healthCheckConfigResult);

        return healthCheckConfigResult;
    }

    private Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig CreateHealthCheckConfig()
    {
        var healthCheckConfigResult = new Humidifier.RTBFabric.ResponderGatewayTypes.HealthCheckConfig();

        return healthCheckConfigResult;
    }

} // End Of Class

public static class InnerResponderGatewayHealthCheckConfigFactoryExtensions
{
}
