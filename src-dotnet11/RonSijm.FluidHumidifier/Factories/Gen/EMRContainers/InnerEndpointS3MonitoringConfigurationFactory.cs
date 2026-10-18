// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRContainers;

public class InnerEndpointS3MonitoringConfigurationFactory(Action<Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration>
{

    protected override Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration Create()
    {
        var s3MonitoringConfigurationResult = CreateS3MonitoringConfiguration();
        factoryAction?.Invoke(s3MonitoringConfigurationResult);

        return s3MonitoringConfigurationResult;
    }

    private Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration CreateS3MonitoringConfiguration()
    {
        var s3MonitoringConfigurationResult = new Humidifier.EMRContainers.EndpointTypes.S3MonitoringConfiguration();

        return s3MonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerEndpointS3MonitoringConfigurationFactoryExtensions
{
}
