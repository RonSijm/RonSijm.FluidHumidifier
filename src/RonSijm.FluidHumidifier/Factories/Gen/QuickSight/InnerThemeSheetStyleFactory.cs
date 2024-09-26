// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeSheetStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.SheetStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.SheetStyle>
{

    internal InnerThemeTileLayoutStyleFactory TileLayoutFactory { get; set; }

    internal InnerThemeTileStyleFactory TileFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.SheetStyle Create()
    {
        var sheetStyleResult = CreateSheetStyle();
        factoryAction?.Invoke(sheetStyleResult);

        return sheetStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.SheetStyle CreateSheetStyle()
    {
        var sheetStyleResult = new Humidifier.QuickSight.ThemeTypes.SheetStyle();

        return sheetStyleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.SheetStyle result)
    {
        base.CreateChildren(result);

        result.TileLayout ??= TileLayoutFactory?.Build();
        result.Tile ??= TileFactory?.Build();
    }

} // End Of Class

public static class InnerThemeSheetStyleFactoryExtensions
{
    public static CombinedResult<InnerThemeSheetStyleFactory, InnerThemeTileLayoutStyleFactory> WithTileLayout(this InnerThemeSheetStyleFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null)
    {
        parentFactory.TileLayoutFactory = new InnerThemeTileLayoutStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TileLayoutFactory);
    }

    public static CombinedResult<InnerThemeSheetStyleFactory, InnerThemeTileStyleFactory> WithTile(this InnerThemeSheetStyleFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null)
    {
        parentFactory.TileFactory = new InnerThemeTileStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TileFactory);
    }

    public static CombinedResult<InnerThemeSheetStyleFactory, T1, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1>(this CombinedResult<InnerThemeSheetStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithTileLayout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1>(this CombinedResult<T1, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithTileLayout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, T4, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3, T4>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, T4, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, T4, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, T4, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeSheetStyleFactory, InnerThemeTileLayoutStyleFactory> WithTileLayout<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileLayoutStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTileLayout(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, InnerThemeTileStyleFactory> WithTile<T1>(this CombinedResult<InnerThemeSheetStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithTile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, InnerThemeTileStyleFactory> WithTile<T1>(this CombinedResult<T1, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithTile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, InnerThemeTileStyleFactory> WithTile<T1, T2>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, InnerThemeTileStyleFactory> WithTile<T1, T2>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, InnerThemeTileStyleFactory> WithTile<T1, T2>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, InnerThemeTileStyleFactory> WithTile<T1, T2, T3>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, InnerThemeTileStyleFactory> WithTile<T1, T2, T3>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, InnerThemeTileStyleFactory> WithTile<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, InnerThemeTileStyleFactory> WithTile<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, T4, InnerThemeTileStyleFactory> WithTile<T1, T2, T3, T4>(this CombinedResult<InnerThemeSheetStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, T4, InnerThemeTileStyleFactory> WithTile<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeSheetStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, T4, InnerThemeTileStyleFactory> WithTile<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeSheetStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, T4, InnerThemeTileStyleFactory> WithTile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeSheetStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeSheetStyleFactory, InnerThemeTileStyleFactory> WithTile<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeSheetStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.TileStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTile(combinedResult.T5, subFactoryAction));
}
