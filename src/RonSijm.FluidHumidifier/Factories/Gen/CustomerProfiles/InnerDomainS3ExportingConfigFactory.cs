// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CustomerProfiles;

public class InnerDomainS3ExportingConfigFactory(Action<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig> factoryAction = null) : SubResourceFactory<Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig>
{

    protected override Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig Create()
    {
        var s3ExportingConfigResult = CreateS3ExportingConfig();
        factoryAction?.Invoke(s3ExportingConfigResult);

        return s3ExportingConfigResult;
    }

    private Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig CreateS3ExportingConfig()
    {
        var s3ExportingConfigResult = new Humidifier.CustomerProfiles.DomainTypes.S3ExportingConfig();

        return s3ExportingConfigResult;
    }

} // End Of Class

public static class InnerDomainS3ExportingConfigFactoryExtensions
{
}
