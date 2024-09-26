// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerDataSourceS3DataSourceConfigurationFactory(Action<Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration>
{

    protected override Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration Create()
    {
        var s3DataSourceConfigurationResult = CreateS3DataSourceConfiguration();
        factoryAction?.Invoke(s3DataSourceConfigurationResult);

        return s3DataSourceConfigurationResult;
    }

    private Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration CreateS3DataSourceConfiguration()
    {
        var s3DataSourceConfigurationResult = new Humidifier.Bedrock.DataSourceTypes.S3DataSourceConfiguration();

        return s3DataSourceConfigurationResult;
    }

} // End Of Class

public static class InnerDataSourceS3DataSourceConfigurationFactoryExtensions
{
}
