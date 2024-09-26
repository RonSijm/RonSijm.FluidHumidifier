// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeBorderStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.BorderStyle>
{

    protected override Humidifier.QuickSight.ThemeTypes.BorderStyle Create()
    {
        var borderStyleResult = CreateBorderStyle();
        factoryAction?.Invoke(borderStyleResult);

        return borderStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.BorderStyle CreateBorderStyle()
    {
        var borderStyleResult = new Humidifier.QuickSight.ThemeTypes.BorderStyle();

        return borderStyleResult;
    }

} // End Of Class

public static class InnerThemeBorderStyleFactoryExtensions
{
}
