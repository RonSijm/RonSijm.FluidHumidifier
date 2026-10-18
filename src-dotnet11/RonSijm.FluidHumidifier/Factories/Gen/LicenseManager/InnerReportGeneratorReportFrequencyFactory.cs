// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.LicenseManager;

public class InnerReportGeneratorReportFrequencyFactory(Action<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency> factoryAction = null) : SubResourceFactory<Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency>
{

    protected override Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency Create()
    {
        var reportFrequencyResult = CreateReportFrequency();
        factoryAction?.Invoke(reportFrequencyResult);

        return reportFrequencyResult;
    }

    private Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency CreateReportFrequency()
    {
        var reportFrequencyResult = new Humidifier.LicenseManager.ReportGeneratorTypes.ReportFrequency();

        return reportFrequencyResult;
    }

} // End Of Class

public static class InnerReportGeneratorReportFrequencyFactoryExtensions
{
}
