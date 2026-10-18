// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeFontWeightFactory(Action<Humidifier.QuickSight.ThemeTypes.FontWeight> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.FontWeight>
{

    protected override Humidifier.QuickSight.ThemeTypes.FontWeight Create()
    {
        var fontWeightResult = CreateFontWeight();
        factoryAction?.Invoke(fontWeightResult);

        return fontWeightResult;
    }

    private Humidifier.QuickSight.ThemeTypes.FontWeight CreateFontWeight()
    {
        var fontWeightResult = new Humidifier.QuickSight.ThemeTypes.FontWeight();

        return fontWeightResult;
    }

} // End Of Class

public static class InnerThemeFontWeightFactoryExtensions
{
}
