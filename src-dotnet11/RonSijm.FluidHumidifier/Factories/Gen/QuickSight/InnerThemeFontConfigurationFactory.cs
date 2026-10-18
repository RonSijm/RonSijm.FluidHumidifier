// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeFontConfigurationFactory(Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.FontConfiguration>
{

    internal InnerThemeFontWeightFactory FontWeightFactory { get; set; }

    internal InnerThemeFontSizeFactory FontSizeFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.FontConfiguration Create()
    {
        var fontConfigurationResult = CreateFontConfiguration();
        factoryAction?.Invoke(fontConfigurationResult);

        return fontConfigurationResult;
    }

    private Humidifier.QuickSight.ThemeTypes.FontConfiguration CreateFontConfiguration()
    {
        var fontConfigurationResult = new Humidifier.QuickSight.ThemeTypes.FontConfiguration();

        return fontConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.FontConfiguration result)
    {
        base.CreateChildren(result);

        result.FontWeight ??= FontWeightFactory?.Build();
        result.FontSize ??= FontSizeFactory?.Build();
    }

} // End Of Class

public static class InnerThemeFontConfigurationFactoryExtensions
{
    public static CombinedResult<InnerThemeFontConfigurationFactory, InnerThemeFontWeightFactory> WithFontWeight(this InnerThemeFontConfigurationFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null)
    {
        parentFactory.FontWeightFactory = new InnerThemeFontWeightFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontWeightFactory);
    }

    public static CombinedResult<InnerThemeFontConfigurationFactory, InnerThemeFontSizeFactory> WithFontSize(this InnerThemeFontConfigurationFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null)
    {
        parentFactory.FontSizeFactory = new InnerThemeFontSizeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontSizeFactory);
    }

    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, InnerThemeFontWeightFactory> WithFontWeight<T1>(this CombinedResult<InnerThemeFontConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontWeight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, InnerThemeFontWeightFactory> WithFontWeight<T1>(this CombinedResult<T1, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontWeight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, InnerThemeFontWeightFactory> WithFontWeight<T1, T2>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, InnerThemeFontWeightFactory> WithFontWeight<T1, T2>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, InnerThemeFontWeightFactory> WithFontWeight<T1, T2>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, T4, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3, T4>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, T4, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, T4, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, T4, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerThemeFontConfigurationFactory, InnerThemeFontWeightFactory> WithFontWeight<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontWeight> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontWeight(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, InnerThemeFontSizeFactory> WithFontSize<T1>(this CombinedResult<InnerThemeFontConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, InnerThemeFontSizeFactory> WithFontSize<T1>(this CombinedResult<T1, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, InnerThemeFontSizeFactory> WithFontSize<T1, T2>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, InnerThemeFontSizeFactory> WithFontSize<T1, T2>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, InnerThemeFontSizeFactory> WithFontSize<T1, T2>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, T4, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3, T4>(this CombinedResult<InnerThemeFontConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, T4, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeFontConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, T4, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeFontConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, T4, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeFontConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerThemeFontConfigurationFactory, InnerThemeFontSizeFactory> WithFontSize<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontSize> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontSize(combinedResult.T5, subFactoryAction).T2);
}
