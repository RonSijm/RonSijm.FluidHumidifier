// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ImageBuilder;

public class InnerInfrastructureConfigurationS3LogsFactory(Action<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs> factoryAction = null) : SubResourceFactory<Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs>
{

    protected override Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs Create()
    {
        var s3LogsResult = CreateS3Logs();
        factoryAction?.Invoke(s3LogsResult);

        return s3LogsResult;
    }

    private Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs CreateS3Logs()
    {
        var s3LogsResult = new Humidifier.ImageBuilder.InfrastructureConfigurationTypes.S3Logs();

        return s3LogsResult;
    }

} // End Of Class

public static class InnerInfrastructureConfigurationS3LogsFactoryExtensions
{
}
