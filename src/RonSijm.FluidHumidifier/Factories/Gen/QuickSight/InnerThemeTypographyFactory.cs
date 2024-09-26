// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeTypographyFactory(Action<Humidifier.QuickSight.ThemeTypes.Typography> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.Typography>
{

    protected override Humidifier.QuickSight.ThemeTypes.Typography Create()
    {
        var typographyResult = CreateTypography();
        factoryAction?.Invoke(typographyResult);

        return typographyResult;
    }

    private Humidifier.QuickSight.ThemeTypes.Typography CreateTypography()
    {
        var typographyResult = new Humidifier.QuickSight.ThemeTypes.Typography();

        return typographyResult;
    }

} // End Of Class

public static class InnerThemeTypographyFactoryExtensions
{
}
