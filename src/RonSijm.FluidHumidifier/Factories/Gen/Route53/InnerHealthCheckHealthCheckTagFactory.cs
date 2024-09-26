// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53;

public class InnerHealthCheckHealthCheckTagFactory(Action<Humidifier.Route53.HealthCheckTypes.HealthCheckTag> factoryAction = null) : SubResourceFactory<Humidifier.Route53.HealthCheckTypes.HealthCheckTag>
{

    protected override Humidifier.Route53.HealthCheckTypes.HealthCheckTag Create()
    {
        var healthCheckTagResult = CreateHealthCheckTag();
        factoryAction?.Invoke(healthCheckTagResult);

        return healthCheckTagResult;
    }

    private Humidifier.Route53.HealthCheckTypes.HealthCheckTag CreateHealthCheckTag()
    {
        var healthCheckTagResult = new Humidifier.Route53.HealthCheckTypes.HealthCheckTag();

        return healthCheckTagResult;
    }

} // End Of Class

public static class InnerHealthCheckHealthCheckTagFactoryExtensions
{
}
