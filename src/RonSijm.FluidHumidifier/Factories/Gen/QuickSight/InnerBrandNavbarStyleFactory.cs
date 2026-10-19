// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerBrandNavbarStyleFactory(Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.BrandTypes.NavbarStyle>
{

    internal InnerBrandPaletteFactory GlobalNavbarFactory { get; set; }

    internal InnerBrandPaletteFactory ContextualNavbarFactory { get; set; }

    protected override Humidifier.QuickSight.BrandTypes.NavbarStyle Create()
    {
        var navbarStyleResult = CreateNavbarStyle();
        factoryAction?.Invoke(navbarStyleResult);

        return navbarStyleResult;
    }

    private Humidifier.QuickSight.BrandTypes.NavbarStyle CreateNavbarStyle()
    {
        var navbarStyleResult = new Humidifier.QuickSight.BrandTypes.NavbarStyle();

        return navbarStyleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.BrandTypes.NavbarStyle result)
    {
        base.CreateChildren(result);

        result.GlobalNavbar ??= GlobalNavbarFactory?.Build();
        result.ContextualNavbar ??= ContextualNavbarFactory?.Build();
    }

} // End Of Class

public static class InnerBrandNavbarStyleFactoryExtensions
{
    public static CombinedResult<InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithGlobalNavbar(this InnerBrandNavbarStyleFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null)
    {
        parentFactory.GlobalNavbarFactory = new InnerBrandPaletteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GlobalNavbarFactory);
    }

    public static CombinedResult<InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithContextualNavbar(this InnerBrandNavbarStyleFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null)
    {
        parentFactory.ContextualNavbarFactory = new InnerBrandPaletteFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContextualNavbarFactory);
    }

    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, InnerBrandPaletteFactory> WithGlobalNavbar<T1>(this CombinedResult<InnerBrandNavbarStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithGlobalNavbar<T1>(this CombinedResult<T1, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, T4, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3, T4>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, T4, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, T4, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, T4, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithGlobalNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGlobalNavbar(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, InnerBrandPaletteFactory> WithContextualNavbar<T1>(this CombinedResult<InnerBrandNavbarStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, WithContextualNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithContextualNavbar<T1>(this CombinedResult<T1, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, WithContextualNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, T4, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3, T4>(this CombinedResult<InnerBrandNavbarStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, T4, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandNavbarStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, T4, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandNavbarStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, T4, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandNavbarStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandNavbarStyleFactory, InnerBrandPaletteFactory> WithContextualNavbar<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandNavbarStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.Palette> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContextualNavbar(combinedResult.T5, subFactoryAction).T2);
}
