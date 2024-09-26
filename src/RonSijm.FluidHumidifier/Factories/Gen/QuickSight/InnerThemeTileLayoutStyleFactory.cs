// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeTileLayoutStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle>
{

    internal InnerThemeGutterStyleFactory GutterFactory { get; set; }

    internal InnerThemeMarginStyleFactory MarginFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.TileLayoutStyle Create()
    {
        var tileLayoutStyleResult = CreateTileLayoutStyle();
        factoryAction?.Invoke(tileLayoutStyleResult);

        return tileLayoutStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.TileLayoutStyle CreateTileLayoutStyle()
    {
        var tileLayoutStyleResult = new Humidifier.QuickSight.ThemeTypes.TileLayoutStyle();

        return tileLayoutStyleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.TileLayoutStyle result)
    {
        base.CreateChildren(result);

        result.Gutter ??= GutterFactory?.Build();
        result.Margin ??= MarginFactory?.Build();
    }

} // End Of Class

public static class InnerThemeTileLayoutStyleFactoryExtensions
{
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, InnerThemeGutterStyleFactory> WithGutter(this InnerThemeTileLayoutStyleFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null)
    {
        parentFactory.GutterFactory = new InnerThemeGutterStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GutterFactory);
    }

    public static CombinedResult<InnerThemeTileLayoutStyleFactory, InnerThemeMarginStyleFactory> WithMargin(this InnerThemeTileLayoutStyleFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null)
    {
        parentFactory.MarginFactory = new InnerThemeMarginStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MarginFactory);
    }

    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, InnerThemeGutterStyleFactory> WithGutter<T1>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithGutter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, InnerThemeGutterStyleFactory> WithGutter<T1>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithGutter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, InnerThemeGutterStyleFactory> WithGutter<T1, T2>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, InnerThemeGutterStyleFactory> WithGutter<T1, T2>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, InnerThemeGutterStyleFactory> WithGutter<T1, T2>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, T4, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3, T4>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, T4, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, T4, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, T4, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeTileLayoutStyleFactory, InnerThemeGutterStyleFactory> WithGutter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.GutterStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGutter(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, InnerThemeMarginStyleFactory> WithMargin<T1>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, InnerThemeMarginStyleFactory> WithMargin<T1>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, InnerThemeMarginStyleFactory> WithMargin<T1, T2>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, InnerThemeMarginStyleFactory> WithMargin<T1, T2>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, InnerThemeMarginStyleFactory> WithMargin<T1, T2>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, T4, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3, T4>(this CombinedResult<InnerThemeTileLayoutStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, T4, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeTileLayoutStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, T4, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeTileLayoutStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, T4, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeTileLayoutStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeTileLayoutStyleFactory, InnerThemeMarginStyleFactory> WithMargin<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeTileLayoutStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.MarginStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMargin(combinedResult.T5, subFactoryAction));
}
