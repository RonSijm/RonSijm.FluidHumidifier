// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class ThemeFactory(string resourceName = null, Action<Humidifier.AmplifyUIBuilder.Theme> factoryAction = null) : ResourceFactory<Humidifier.AmplifyUIBuilder.Theme>(resourceName)
{

    internal List<InnerThemeThemeValuesFactory> ValuesFactories { get; set; } = [];

    internal List<InnerThemeThemeValuesFactory> OverridesFactories { get; set; } = [];

    protected override Humidifier.AmplifyUIBuilder.Theme Create()
    {
        var themeResult = CreateTheme();
        factoryAction?.Invoke(themeResult);

        return themeResult;
    }

    private Humidifier.AmplifyUIBuilder.Theme CreateTheme()
    {
        var themeResult = new Humidifier.AmplifyUIBuilder.Theme
        {
            GivenName = InputResourceName,
        };

        return themeResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.Theme result)
    {
        base.CreateChildren(result);

        result.Values = ValuesFactories.Any() ? ValuesFactories.Select(x => x.Build()).ToList() : null;
        result.Overrides = OverridesFactories.Any() ? OverridesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class ThemeFactoryExtensions
{
    public static CombinedResult<ThemeFactory, InnerThemeThemeValuesFactory> WithValues(this ThemeFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null)
    {
        var factory = new InnerThemeThemeValuesFactory(subFactoryAction);
        parentFactory.ValuesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ThemeFactory, InnerThemeThemeValuesFactory> WithOverrides(this ThemeFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null)
    {
        var factory = new InnerThemeThemeValuesFactory(subFactoryAction);
        parentFactory.OverridesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<ThemeFactory, T1, InnerThemeThemeValuesFactory> WithValues<T1>(this CombinedResult<ThemeFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, InnerThemeThemeValuesFactory> WithValues<T1>(this CombinedResult<T1, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, InnerThemeThemeValuesFactory> WithValues<T1, T2>(this CombinedResult<ThemeFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, InnerThemeThemeValuesFactory> WithValues<T1, T2>(this CombinedResult<T1, ThemeFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, InnerThemeThemeValuesFactory> WithValues<T1, T2>(this CombinedResult<T1, T2, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<ThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, ThemeFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, ThemeFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, T4, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<ThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, T4, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, ThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, T4, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThemeFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, T4, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThemeFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThemeFactory, InnerThemeThemeValuesFactory> WithValues<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValues(combinedResult.T5, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, InnerThemeThemeValuesFactory> WithOverrides<T1>(this CombinedResult<ThemeFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, InnerThemeThemeValuesFactory> WithOverrides<T1>(this CombinedResult<T1, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, InnerThemeThemeValuesFactory> WithOverrides<T1, T2>(this CombinedResult<ThemeFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, InnerThemeThemeValuesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, ThemeFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, InnerThemeThemeValuesFactory> WithOverrides<T1, T2>(this CombinedResult<T1, T2, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<ThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, ThemeFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, ThemeFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<ThemeFactory, T1, T2, T3, T4, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<ThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, ThemeFactory, T2, T3, T4, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, ThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, ThemeFactory, T3, T4, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, ThemeFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, ThemeFactory, T4, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, ThemeFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, ThemeFactory, InnerThemeThemeValuesFactory> WithOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, ThemeFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrides(combinedResult.T5, subFactoryAction));
}
