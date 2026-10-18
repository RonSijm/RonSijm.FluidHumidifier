// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ARCRegionSwitch;

public class InnerPlanReportConfigurationFactory(Action<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration>
{

    protected override Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration Create()
    {
        var reportConfigurationResult = CreateReportConfiguration();
        factoryAction?.Invoke(reportConfigurationResult);

        return reportConfigurationResult;
    }

    private Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration CreateReportConfiguration()
    {
        var reportConfigurationResult = new Humidifier.ARCRegionSwitch.PlanTypes.ReportConfiguration();

        return reportConfigurationResult;
    }

} // End Of Class

public static class InnerPlanReportConfigurationFactoryExtensions
{
}
