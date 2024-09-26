// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CodeBuild;

public class InnerReportGroupS3ReportExportConfigFactory(Action<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig> factoryAction = null) : SubResourceFactory<Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig>
{

    protected override Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig Create()
    {
        var s3ReportExportConfigResult = CreateS3ReportExportConfig();
        factoryAction?.Invoke(s3ReportExportConfigResult);

        return s3ReportExportConfigResult;
    }

    private Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig CreateS3ReportExportConfig()
    {
        var s3ReportExportConfigResult = new Humidifier.CodeBuild.ReportGroupTypes.S3ReportExportConfig();

        return s3ReportExportConfigResult;
    }

} // End Of Class

public static class InnerReportGroupS3ReportExportConfigFactoryExtensions
{
}
