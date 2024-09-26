// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeDataColorPaletteFactory(Action<Humidifier.QuickSight.ThemeTypes.DataColorPalette> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.DataColorPalette>
{

    protected override Humidifier.QuickSight.ThemeTypes.DataColorPalette Create()
    {
        var dataColorPaletteResult = CreateDataColorPalette();
        factoryAction?.Invoke(dataColorPaletteResult);

        return dataColorPaletteResult;
    }

    private Humidifier.QuickSight.ThemeTypes.DataColorPalette CreateDataColorPalette()
    {
        var dataColorPaletteResult = new Humidifier.QuickSight.ThemeTypes.DataColorPalette();

        return dataColorPaletteResult;
    }

} // End Of Class

public static class InnerThemeDataColorPaletteFactoryExtensions
{
}
