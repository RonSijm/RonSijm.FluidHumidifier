// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardExportWithHiddenFieldsOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption Create()
    {
        var exportWithHiddenFieldsOptionResult = CreateExportWithHiddenFieldsOption();
        factoryAction?.Invoke(exportWithHiddenFieldsOptionResult);

        return exportWithHiddenFieldsOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption CreateExportWithHiddenFieldsOption()
    {
        var exportWithHiddenFieldsOptionResult = new Humidifier.QuickSight.DashboardTypes.ExportWithHiddenFieldsOption();

        return exportWithHiddenFieldsOptionResult;
    }

} // End Of Class

public static class InnerDashboardExportWithHiddenFieldsOptionFactoryExtensions
{
}
