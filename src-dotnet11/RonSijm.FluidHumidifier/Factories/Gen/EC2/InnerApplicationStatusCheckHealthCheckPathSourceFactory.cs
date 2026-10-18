// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EC2;

public class InnerApplicationStatusCheckHealthCheckPathSourceFactory(Action<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource> factoryAction = null) : SubResourceFactory<Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource>
{

    protected override Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource Create()
    {
        var healthCheckPathSourceResult = CreateHealthCheckPathSource();
        factoryAction?.Invoke(healthCheckPathSourceResult);

        return healthCheckPathSourceResult;
    }

    private Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource CreateHealthCheckPathSource()
    {
        var healthCheckPathSourceResult = new Humidifier.EC2.ApplicationStatusCheckTypes.HealthCheckPathSource();

        return healthCheckPathSourceResult;
    }

} // End Of Class

public static class InnerApplicationStatusCheckHealthCheckPathSourceFactoryExtensions
{
}
