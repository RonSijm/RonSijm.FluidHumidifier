// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardExportToCSVOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.ExportToCSVOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ExportToCSVOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.ExportToCSVOption Create()
    {
        var exportToCSVOptionResult = CreateExportToCSVOption();
        factoryAction?.Invoke(exportToCSVOptionResult);

        return exportToCSVOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ExportToCSVOption CreateExportToCSVOption()
    {
        var exportToCSVOptionResult = new Humidifier.QuickSight.DashboardTypes.ExportToCSVOption();

        return exportToCSVOptionResult;
    }

} // End Of Class

public static class InnerDashboardExportToCSVOptionFactoryExtensions
{
}
