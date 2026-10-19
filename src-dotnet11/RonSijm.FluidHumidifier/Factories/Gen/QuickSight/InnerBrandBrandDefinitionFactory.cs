// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class InnerBrandBrandDefinitionFactory(Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> factoryAction = null) : SubResourceFactory<Humidifier.QuickSight.BrandTypes.BrandDefinition>
{

    internal InnerBrandApplicationThemeFactory ApplicationThemeFactory { get; set; }

    protected override Humidifier.QuickSight.BrandTypes.BrandDefinition Create()
    {
        var brandDefinitionResult = CreateBrandDefinition();
        factoryAction?.Invoke(brandDefinitionResult);

        return brandDefinitionResult;
    }

    private Humidifier.QuickSight.BrandTypes.BrandDefinition CreateBrandDefinition()
    {
        var brandDefinitionResult = new Humidifier.QuickSight.BrandTypes.BrandDefinition();

        return brandDefinitionResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.BrandTypes.BrandDefinition result)
    {
        base.CreateChildren(result);

        result.ApplicationTheme ??= ApplicationThemeFactory?.Build();
    }

} // End Of Class

public static class InnerBrandBrandDefinitionFactoryExtensions
{
    public static CombinedResult<InnerBrandBrandDefinitionFactory, InnerBrandApplicationThemeFactory> WithApplicationTheme(this InnerBrandBrandDefinitionFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null)
    {
        parentFactory.ApplicationThemeFactory = new InnerBrandApplicationThemeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ApplicationThemeFactory);
    }

    public static CombinedResult<InnerBrandBrandDefinitionFactory, T1, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1>(this CombinedResult<InnerBrandBrandDefinitionFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandDefinitionFactory, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1>(this CombinedResult<T1, InnerBrandBrandDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, WithApplicationTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2>(this CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2>(this CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2>(this CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2, T3, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3>(this CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2, T3, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3>(this CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory, T3, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3>(this CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandBrandDefinitionFactory, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBrandBrandDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2, T3, T4, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3, T4>(this CombinedResult<InnerBrandBrandDefinitionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2, T3, T4, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3, T4>(this CombinedResult<T1, InnerBrandBrandDefinitionFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory, T3, T4, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBrandBrandDefinitionFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBrandBrandDefinitionFactory, T4, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBrandBrandDefinitionFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBrandBrandDefinitionFactory, InnerBrandApplicationThemeFactory> WithApplicationTheme<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBrandBrandDefinitionFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.ApplicationTheme> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithApplicationTheme(combinedResult.T5, subFactoryAction).T2);
}
