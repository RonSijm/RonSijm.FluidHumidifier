// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ObservabilityAdmin;

public class InnerS3TableIntegrationLogSourceFactory(Action<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource> factoryAction = null) : SubResourceFactory<Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource>
{

    protected override Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource Create()
    {
        var logSourceResult = CreateLogSource();
        factoryAction?.Invoke(logSourceResult);

        return logSourceResult;
    }

    private Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource CreateLogSource()
    {
        var logSourceResult = new Humidifier.ObservabilityAdmin.S3TableIntegrationTypes.LogSource();

        return logSourceResult;
    }

} // End Of Class

public static class InnerS3TableIntegrationLogSourceFactoryExtensions
{
}
