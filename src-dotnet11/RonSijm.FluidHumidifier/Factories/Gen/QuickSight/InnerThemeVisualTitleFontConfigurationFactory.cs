// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeVisualTitleFontConfigurationFactory(Action<Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration>
{

    internal InnerThemeFontConfigurationFactory FontConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration Create()
    {
        var visualTitleFontConfigurationResult = CreateVisualTitleFontConfiguration();
        factoryAction?.Invoke(visualTitleFontConfigurationResult);

        return visualTitleFontConfigurationResult;
    }

    private Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration CreateVisualTitleFontConfiguration()
    {
        var visualTitleFontConfigurationResult = new Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration();

        return visualTitleFontConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.VisualTitleFontConfiguration result)
    {
        base.CreateChildren(result);

        result.FontConfiguration ??= FontConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerThemeVisualTitleFontConfigurationFactoryExtensions
{
    public static CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration(this InnerThemeVisualTitleFontConfigurationFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null)
    {
        parentFactory.FontConfigurationFactory = new InnerThemeFontConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontConfigurationFactory);
    }

    public static CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1>(this CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1>(this CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeVisualTitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeVisualTitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerThemeVisualTitleFontConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeVisualTitleFontConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeVisualTitleFontConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeVisualTitleFontConfigurationFactory, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeVisualTitleFontConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerThemeVisualTitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeVisualTitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T5, subFactoryAction).T2);
}
