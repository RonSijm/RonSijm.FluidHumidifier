// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class InnerWorkGroupS3LoggingConfigurationFactory(Action<Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration>
{

    protected override Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration Create()
    {
        var s3LoggingConfigurationResult = CreateS3LoggingConfiguration();
        factoryAction?.Invoke(s3LoggingConfigurationResult);

        return s3LoggingConfigurationResult;
    }

    private Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration CreateS3LoggingConfiguration()
    {
        var s3LoggingConfigurationResult = new Humidifier.Athena.WorkGroupTypes.S3LoggingConfiguration();

        return s3LoggingConfigurationResult;
    }

} // End Of Class

public static class InnerWorkGroupS3LoggingConfigurationFactoryExtensions
{
}
