// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerBrandBrandElementStyleFactory(Action<Humidifier.QuickSight.BrandTypes.BrandElementStyle> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.BrandTypes.BrandElementStyle>
{

    internal InnerBrandNavbarStyleFactory NavbarStyleFactory { get; set; }

    protected override Humidifier.QuickSight.BrandTypes.BrandElementStyle Create()
    {
        var brandElementStyleResult = CreateBrandElementStyle();
        factoryAction?.Invoke(brandElementStyleResult);

        return brandElementStyleResult;
    }

    private Humidifier.QuickSight.BrandTypes.BrandElementStyle CreateBrandElementStyle()
    {
        var brandElementStyleResult = new Humidifier.QuickSight.BrandTypes.BrandElementStyle();

        return brandElementStyleResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.BrandTypes.BrandElementStyle result)
    {
        base.CreateChildren(result);

        result.NavbarStyle ??= NavbarStyleFactory?.Build();
    }

} // End Of Class

public static class InnerBrandBrandElementStyleFactoryExtensions
{
    public static CombinedResult<InnerBrandBrandElementStyleFactory, InnerBrandNavbarStyleFactory> WithNavbarStyle(this InnerBrandBrandElementStyleFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null)
    {
        parentFactory.NavbarStyleFactory = new InnerBrandNavbarStyleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NavbarStyleFactory);
    }

    public static CombinedResult<InnerBrandBrandElementStyleFactory, T1, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1>(this CombinedResult<InnerBrandBrandElementStyleFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithNavbarStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandElementStyleFactory, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1>(this CombinedResult<T1, InnerBrandBrandElementStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, WithNavbarStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2>(this CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2>(this CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2>(this CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2, T3, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3>(this CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2, T3, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3>(this CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory, T3, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandBrandElementStyleFactory, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandBrandElementStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2, T3, T4, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3, T4>(this CombinedResult<InnerBrandBrandElementStyleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2, T3, T4, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandBrandElementStyleFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory, T3, T4, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandBrandElementStyleFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandBrandElementStyleFactory, T4, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandBrandElementStyleFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandBrandElementStyleFactory, InnerBrandNavbarStyleFactory> WithNavbarStyle<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandBrandElementStyleFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.NavbarStyle> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNavbarStyle(combinedResult.T5, subFactoryAction).T2);
}
