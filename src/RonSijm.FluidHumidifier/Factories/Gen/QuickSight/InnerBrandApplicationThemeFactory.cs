// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerBrandApplicationThemeFactory(Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.BrandTypes.ApplicationTheme>
{

    internal InnerBrandBrandColorPaletteFactory BrandColorPaletteFactory { get; set; }

    internal InnerBrandBrandElementStyleFactory BrandElementStyleFactory { get; set; }

    protected override Humidifier.QuickSight.BrandTypes.ApplicationTheme Create()
    {
        var applicationThemeResult = CreateApplicationTheme();
        factoryAction?.Invoke(applicationThemeResult);

        return applicationThemeResult;
    }

    private Humidifier.QuickSight.BrandTypes.ApplicationTheme CreateApplicationTheme()
    {
        var applicationThemeResult = new Humidifier.QuickSight.BrandTypes.ApplicationTheme();

        return applicationThemeResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.BrandTypes.ApplicationTheme result)
    {
        base.CreateChildren(result);

        result.BrandColorPalette ??= BrandColorPaletteFactory?.Build();
        result.BrandElementStyle ??= BrandElementStyleFactory?.Build();
    }

} // End Of Class

public static class InnerBrandApplicationThemeFactoryExtensions
{
    public static CombinedResult<InnerBrandApplicationThemeFactory, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette(this InnerBrandApplicationThemeFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null)
    {
        parentFactory.BrandColorPaletteFactory = new InnerBrandBrandColorPaletteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BrandColorPaletteFactory);
    }

    public static CombinedResult<InnerBrandApplicationThemeFactory, InnerBrandBrandElementStyleFactory> WithBrandElementStyle(this InnerBrandApplicationThemeFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null)
    {
        parentFactory.BrandElementStyleFactory = new InnerBrandBrandElementStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BrandElementStyleFactory);
    }

    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1>(this CombinedResult<InnerBrandApplicationThemeFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1>(this CombinedResult<T1, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, T4, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3, T4>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, T4, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, T4, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, T4, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandApplicationThemeFactory, InnerBrandBrandColorPaletteFactory> WithBrandColorPalette<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandColorPalette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandColorPalette(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1>(this CombinedResult<InnerBrandApplicationThemeFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1>(this CombinedResult<T1, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, T4, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3, T4>(this CombinedResult<InnerBrandApplicationThemeFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, T4, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandApplicationThemeFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, T4, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandApplicationThemeFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, T4, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandApplicationThemeFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandApplicationThemeFactory, InnerBrandBrandElementStyleFactory> WithBrandElementStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandApplicationThemeFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandElementStyle(combinedResult.T5, subFactoryAction).T2);
}
