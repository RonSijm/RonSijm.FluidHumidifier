// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardSheetControlsOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.SheetControlsOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.SheetControlsOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.SheetControlsOption Create()
    {
        var sheetControlsOptionResult = CreateSheetControlsOption();
        factoryAction?.Invoke(sheetControlsOptionResult);

        return sheetControlsOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.SheetControlsOption CreateSheetControlsOption()
    {
        var sheetControlsOptionResult = new Humidifier.QuickSight.DashboardTypes.SheetControlsOption();

        return sheetControlsOptionResult;
    }

} // End Of Class

public static class InnerDashboardSheetControlsOptionFactoryExtensions
{
}
