// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeMarginStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.MarginStyle>
{

    protected override Humidifier.QuickSight.ThemeTypes.MarginStyle Create()
    {
        var marginStyleResult = CreateMarginStyle();
        factoryAction?.Invoke(marginStyleResult);

        return marginStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.MarginStyle CreateMarginStyle()
    {
        var marginStyleResult = new Humidifier.QuickSight.ThemeTypes.MarginStyle();

        return marginStyleResult;
    }

} // End Of Class

public static class InnerThemeMarginStyleFactoryExtensions
{
}
