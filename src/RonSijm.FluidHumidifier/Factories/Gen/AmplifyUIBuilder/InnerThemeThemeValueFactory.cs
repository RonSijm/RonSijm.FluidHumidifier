// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerThemeThemeValueFactory(Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue>
{

    protected override Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue Create()
    {
        var themeValueResult = CreateThemeValue();
        factoryAction?.Invoke(themeValueResult);

        return themeValueResult;
    }

    private Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue CreateThemeValue()
    {
        var themeValueResult = new Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue();

        return themeValueResult;
    }

} // End Of Class

public static class InnerThemeThemeValueFactoryExtensions
{
}
