// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeUIColorPaletteFactory(Action<Humidifier.QuickSight.ThemeTypes.UIColorPalette> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.UIColorPalette>
{

    protected override Humidifier.QuickSight.ThemeTypes.UIColorPalette Create()
    {
        var uIColorPaletteResult = CreateUIColorPalette();
        factoryAction?.Invoke(uIColorPaletteResult);

        return uIColorPaletteResult;
    }

    private Humidifier.QuickSight.ThemeTypes.UIColorPalette CreateUIColorPalette()
    {
        var uIColorPaletteResult = new Humidifier.QuickSight.ThemeTypes.UIColorPalette();

        return uIColorPaletteResult;
    }

} // End Of Class

public static class InnerThemeUIColorPaletteFactoryExtensions
{
}
