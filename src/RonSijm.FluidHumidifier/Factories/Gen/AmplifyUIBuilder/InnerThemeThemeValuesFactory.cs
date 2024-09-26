// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AmplifyUIBuilder;

public class InnerThemeThemeValuesFactory(Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues> factoryAction = null) : SubResourceFactory<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues>
{

    internal InnerThemeThemeValueFactory ValueFactory { get; set; }

    protected override Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues Create()
    {
        var themeValuesResult = CreateThemeValues();
        factoryAction?.Invoke(themeValuesResult);

        return themeValuesResult;
    }

    private Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues CreateThemeValues()
    {
        var themeValuesResult = new Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues();

        return themeValuesResult;
    }
    public override void CreateChildren(Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValues result)
    {
        base.CreateChildren(result);

        result.Value ??= ValueFactory?.Build();
    }

} // End Of Class

public static class InnerThemeThemeValuesFactoryExtensions
{
    public static CombinedResult<InnerThemeThemeValuesFactory, InnerThemeThemeValueFactory> WithValue(this InnerThemeThemeValuesFactory parentFactory, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null)
    {
        parentFactory.ValueFactory = new InnerThemeThemeValueFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ValueFactory);
    }

    public static CombinedResult<InnerThemeThemeValuesFactory, T1, InnerThemeThemeValueFactory> WithValue<T1>(this CombinedResult<InnerThemeThemeValuesFactory, T1> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeThemeValuesFactory, InnerThemeThemeValueFactory> WithValue<T1>(this CombinedResult<T1, InnerThemeThemeValuesFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeThemeValuesFactory, T1, T2, InnerThemeThemeValueFactory> WithValue<T1, T2>(this CombinedResult<InnerThemeThemeValuesFactory, T1, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeThemeValuesFactory, T2, InnerThemeThemeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, InnerThemeThemeValuesFactory, T2> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeThemeValuesFactory, InnerThemeThemeValueFactory> WithValue<T1, T2>(this CombinedResult<T1, T2, InnerThemeThemeValuesFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeThemeValuesFactory, T1, T2, T3, InnerThemeThemeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<InnerThemeThemeValuesFactory, T1, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeThemeValuesFactory, T2, T3, InnerThemeThemeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, InnerThemeThemeValuesFactory, T2, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeThemeValuesFactory, T3, InnerThemeThemeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeThemeValuesFactory, T3> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeThemeValuesFactory, InnerThemeThemeValueFactory> WithValue<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeThemeValuesFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeThemeValuesFactory, T1, T2, T3, T4, InnerThemeThemeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<InnerThemeThemeValuesFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeThemeValuesFactory, T2, T3, T4, InnerThemeThemeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeThemeValuesFactory, T2, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeThemeValuesFactory, T3, T4, InnerThemeThemeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeThemeValuesFactory, T3, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeThemeValuesFactory, T4, InnerThemeThemeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeThemeValuesFactory, T4> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeThemeValuesFactory, InnerThemeThemeValueFactory> WithValue<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeThemeValuesFactory> combinedResult, Action<Humidifier.AmplifyUIBuilder.ThemeTypes.ThemeValue> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithValue(combinedResult.T5, subFactoryAction));
}
