// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeSheetBackgroundStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle>
{

    protected override Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle Create()
    {
        var sheetBackgroundStyleResult = CreateSheetBackgroundStyle();
        factoryAction?.Invoke(sheetBackgroundStyleResult);

        return sheetBackgroundStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle CreateSheetBackgroundStyle()
    {
        var sheetBackgroundStyleResult = new Humidifier.QuickSight.ThemeTypes.SheetBackgroundStyle();

        return sheetBackgroundStyleResult;
    }

} // End Of Class

public static class InnerThemeSheetBackgroundStyleFactoryExtensions
{
}
