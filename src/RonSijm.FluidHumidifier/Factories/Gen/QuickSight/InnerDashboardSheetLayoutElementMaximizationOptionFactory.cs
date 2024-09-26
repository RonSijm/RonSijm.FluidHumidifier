// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerDashboardSheetLayoutElementMaximizationOptionFactory(Action<Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption>
{

    protected override Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption Create()
    {
        var sheetLayoutElementMaximizationOptionResult = CreateSheetLayoutElementMaximizationOption();
        factoryAction?.Invoke(sheetLayoutElementMaximizationOptionResult);

        return sheetLayoutElementMaximizationOptionResult;
    }

    private Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption CreateSheetLayoutElementMaximizationOption()
    {
        var sheetLayoutElementMaximizationOptionResult = new Humidifier.QuickSight.DashboardTypes.SheetLayoutElementMaximizationOption();

        return sheetLayoutElementMaximizationOptionResult;
    }

} // End Of Class

public static class InnerDashboardSheetLayoutElementMaximizationOptionFactoryExtensions
{
}
