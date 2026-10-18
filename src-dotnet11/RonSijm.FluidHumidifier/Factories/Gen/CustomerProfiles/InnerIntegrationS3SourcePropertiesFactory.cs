// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerIntegrationS3SourcePropertiesFactory(Action<Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties>
{

    protected override Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties Create()
    {
        var s3SourcePropertiesResult = CreateS3SourceProperties();
        factoryAction?.Invoke(s3SourcePropertiesResult);

        return s3SourcePropertiesResult;
    }

    private Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties CreateS3SourceProperties()
    {
        var s3SourcePropertiesResult = new Humidifier.CustomerProfiles.IntegrationTypes.S3SourceProperties();

        return s3SourcePropertiesResult;
    }

} // End Of Class

public static class InnerIntegrationS3SourcePropertiesFactoryExtensions
{
}
