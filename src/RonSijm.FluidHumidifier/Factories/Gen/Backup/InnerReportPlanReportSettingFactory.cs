// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerReportPlanReportSettingFactory(Action<Humidifier.Backup.ReportPlanTypes.ReportSetting> factoryAction = null) : SubResourceFactory<Humidifier.Backup.ReportPlanTypes.ReportSetting>
{

    protected override Humidifier.Backup.ReportPlanTypes.ReportSetting Create()
    {
        var reportSettingResult = CreateReportSetting();
        factoryAction?.Invoke(reportSettingResult);

        return reportSettingResult;
    }

    private Humidifier.Backup.ReportPlanTypes.ReportSetting CreateReportSetting()
    {
        var reportSettingResult = new Humidifier.Backup.ReportPlanTypes.ReportSetting();

        return reportSettingResult;
    }

} // End Of Class

public static class InnerReportPlanReportSettingFactoryExtensions
{
}
