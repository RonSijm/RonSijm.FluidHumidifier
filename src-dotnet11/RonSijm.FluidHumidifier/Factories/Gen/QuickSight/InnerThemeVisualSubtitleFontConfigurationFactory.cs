// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeVisualSubtitleFontConfigurationFactory(Action<Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration>
{

    internal InnerThemeFontConfigurationFactory FontConfigurationFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration Create()
    {
        var visualSubtitleFontConfigurationResult = CreateVisualSubtitleFontConfiguration();
        factoryAction?.Invoke(visualSubtitleFontConfigurationResult);

        return visualSubtitleFontConfigurationResult;
    }

    private Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration CreateVisualSubtitleFontConfiguration()
    {
        var visualSubtitleFontConfigurationResult = new Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration();

        return visualSubtitleFontConfigurationResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.VisualSubtitleFontConfiguration result)
    {
        base.CreateChildren(result);

        result.FontConfiguration ??= FontConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerThemeVisualSubtitleFontConfigurationFactoryExtensions
{
    public static CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration(this InnerThemeVisualSubtitleFontConfigurationFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null)
    {
        parentFactory.FontConfigurationFactory = new InnerThemeFontConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FontConfigurationFactory);
    }

    public static CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1>(this CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1>(this CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory, T3, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeVisualSubtitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeVisualSubtitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerThemeVisualSubtitleFontConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeVisualSubtitleFontConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory, T3, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeVisualSubtitleFontConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerThemeVisualSubtitleFontConfigurationFactory, T4, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeVisualSubtitleFontConfigurationFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerThemeVisualSubtitleFontConfigurationFactory, InnerThemeFontConfigurationFactory> WithFontConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeVisualSubtitleFontConfigurationFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.FontConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFontConfiguration(combinedResult.T5, subFactoryAction).T2);
}
