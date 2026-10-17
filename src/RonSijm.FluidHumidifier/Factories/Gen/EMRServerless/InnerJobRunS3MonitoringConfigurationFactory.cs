// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class InnerJobRunS3MonitoringConfigurationFactory(Action<Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration>
{

    protected override Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration Create()
    {
        var s3MonitoringConfigurationResult = CreateS3MonitoringConfiguration();
        factoryAction?.Invoke(s3MonitoringConfigurationResult);

        return s3MonitoringConfigurationResult;
    }

    private Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration CreateS3MonitoringConfiguration()
    {
        var s3MonitoringConfigurationResult = new Humidifier.EMRServerless.JobRunTypes.S3MonitoringConfiguration();

        return s3MonitoringConfigurationResult;
    }

} // End Of Class

public static class InnerJobRunS3MonitoringConfigurationFactoryExtensions
{
}
