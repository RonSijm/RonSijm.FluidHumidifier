// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeGutterStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.GutterStyle>
{

    protected override Humidifier.QuickSight.ThemeTypes.GutterStyle Create()
    {
        var gutterStyleResult = CreateGutterStyle();
        factoryAction?.Invoke(gutterStyleResult);

        return gutterStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.GutterStyle CreateGutterStyle()
    {
        var gutterStyleResult = new Humidifier.QuickSight.ThemeTypes.GutterStyle();

        return gutterStyleResult;
    }

} // End Of Class

public static class InnerThemeGutterStyleFactoryExtensions
{
}
