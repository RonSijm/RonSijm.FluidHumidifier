// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerThemeTileStyleFactory(Action<Humidifier.QuickSight.ThemeTypes.TileStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.ThemeTypes.TileStyle>
{

    internal InnerThemeBorderStyleFactory BorderFactory { get; set; }

    protected override Humidifier.QuickSight.ThemeTypes.TileStyle Create()
    {
        var tileStyleResult = CreateTileStyle();
        factoryAction?.Invoke(tileStyleResult);

        return tileStyleResult;
    }

    private Humidifier.QuickSight.ThemeTypes.TileStyle CreateTileStyle()
    {
        var tileStyleResult = new Humidifier.QuickSight.ThemeTypes.TileStyle();

        return tileStyleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.ThemeTypes.TileStyle result)
    {
        base.CreateChildren(result);

        result.Border ??= BorderFactory?.Build();
    }

} // End Of Class

public static class InnerThemeTileStyleFactoryExtensions
{
    public static CombinedResult<InnerThemeTileStyleFactory, InnerThemeBorderStyleFactory> WithBorder(this InnerThemeTileStyleFactory parentFactory, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null)
    {
        parentFactory.BorderFactory = new InnerThemeBorderStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BorderFactory);
    }

    public static CombinedResult<InnerThemeTileStyleFactory, T1, InnerThemeBorderStyleFactory> WithBorder<T1>(this CombinedResult<InnerThemeTileStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithBorder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileStyleFactory, InnerThemeBorderStyleFactory> WithBorder<T1>(this CombinedResult<T1, InnerThemeTileStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithBorder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerThemeTileStyleFactory, T1, T2, InnerThemeBorderStyleFactory> WithBorder<T1, T2>(this CombinedResult<InnerThemeTileStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileStyleFactory, T2, InnerThemeBorderStyleFactory> WithBorder<T1, T2>(this CombinedResult<T1, InnerThemeTileStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileStyleFactory, InnerThemeBorderStyleFactory> WithBorder<T1, T2>(this CombinedResult<T1, T2, InnerThemeTileStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerThemeTileStyleFactory, T1, T2, T3, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3>(this CombinedResult<InnerThemeTileStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileStyleFactory, T2, T3, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3>(this CombinedResult<T1, InnerThemeTileStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileStyleFactory, T3, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3>(this CombinedResult<T1, T2, InnerThemeTileStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileStyleFactory, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerThemeTileStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerThemeTileStyleFactory, T1, T2, T3, T4, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3, T4>(this CombinedResult<InnerThemeTileStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerThemeTileStyleFactory, T2, T3, T4, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3, T4>(this CombinedResult<T1, InnerThemeTileStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerThemeTileStyleFactory, T3, T4, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerThemeTileStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerThemeTileStyleFactory, T4, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerThemeTileStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerThemeTileStyleFactory, InnerThemeBorderStyleFactory> WithBorder<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerThemeTileStyleFactory> combinedResult, Action<Humidifier.QuickSight.ThemeTypes.BorderStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBorder(combinedResult.T5, subFactoryAction));
}
