// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerReportGeneratorReportContextFactory(Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext>
{

    protected override Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext Create()
    {
        var reportContextResult = CreateReportContext();
        factoryAction?.Invoke(reportContextResult);

        return reportContextResult;
    }

    private Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext CreateReportContext()
    {
        var reportContextResult = new Humidifier.LicenseManager.ReportGeneratorTypes.ReportContext();

        return reportContextResult;
    }

} // End Of Class

public static class InnerReportGeneratorReportContextFactoryExtensions
{
}
