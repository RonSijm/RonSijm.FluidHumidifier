// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardExportHiddenFieldsOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption Create()
    {
        var exportHiddenFieldsOptionResult = CreateExportHiddenFieldsOption();
        factoryAction?.Invoke(exportHiddenFieldsOptionResult);

        return exportHiddenFieldsOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption CreateExportHiddenFieldsOption()
    {
        var exportHiddenFieldsOptionResult = new Humidifier.QuickSight.DashboardTypes.ExportHiddenFieldsOption();

        return exportHiddenFieldsOptionResult;
    }

} // End Of Class

public static class InnerDashboardExportHiddenFieldsOptionFactoryExtensions
{
}
