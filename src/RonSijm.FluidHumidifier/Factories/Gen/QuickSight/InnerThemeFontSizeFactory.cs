// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeFontSizeFactory(Action<Humidifier.QuickSight.ThemeTypes.FontSize> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.FontSize>
{

    protected override Humidifier.QuickSight.ThemeTypes.FontSize Create()
    {
        var fontSizeResult = CreateFontSize();
        factoryAction?.Invoke(fontSizeResult);

        return fontSizeResult;
    }

    private Humidifier.QuickSight.ThemeTypes.FontSize CreateFontSize()
    {
        var fontSizeResult = new Humidifier.QuickSight.ThemeTypes.FontSize();

        return fontSizeResult;
    }

} // End Of Class

public static class InnerThemeFontSizeFactoryExtensions
{
}
