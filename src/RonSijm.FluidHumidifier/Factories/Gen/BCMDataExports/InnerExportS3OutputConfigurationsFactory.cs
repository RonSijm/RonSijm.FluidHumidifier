// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BCMDataExports;

public class InnerExportS3OutputConfigurationsFactory(Action<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations> factoryAction = null) : SubResourceFactory<Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations>
{

    protected override Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations Create()
    {
        var s3OutputConfigurationsResult = CreateS3OutputConfigurations();
        factoryAction?.Invoke(s3OutputConfigurationsResult);

        return s3OutputConfigurationsResult;
    }

    private Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations CreateS3OutputConfigurations()
    {
        var s3OutputConfigurationsResult = new Humidifier.BCMDataExports.ExportTypes.S3OutputConfigurations();

        return s3OutputConfigurationsResult;
    }

} // End Of Class

public static class InnerExportS3OutputConfigurationsFactoryExtensions
{
}
