// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.QuickSight;

public class BrandFactory(string resourceName = null, Action<Humidifier.QuickSight.Brand> factoryAction = null) : ResourceFactory<Humidifier.QuickSight.Brand>(resourceName)
{

    internal InnerBrandBrandDefinitionFactory BrandDefinitionFactory { get; set; }

    protected override Humidifier.QuickSight.Brand Create()
    {
        var brandResult = CreateBrand();
        factoryAction?.Invoke(brandResult);

        return brandResult;
    }

    private Humidifier.QuickSight.Brand CreateBrand()
    {
        var brandResult = new Humidifier.QuickSight.Brand
        {
            GivenName = InputResourceName,
        };

        return brandResult;
    }
    public override void CreateChildren(Humidifier.QuickSight.Brand result)
    {
        base.CreateChildren(result);

        result.BrandDefinition ??= BrandDefinitionFactory?.Build();
    }

} // End Of Class

public static class BrandFactoryExtensions
{
    public static CombinedResult<BrandFactory, InnerBrandBrandDefinitionFactory> WithBrandDefinition(this BrandFactory parentFactory, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null)
    {
        parentFactory.BrandDefinitionFactory = new InnerBrandBrandDefinitionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.BrandDefinitionFactory);
    }

    public static CombinedResult<BrandFactory, T1, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1>(this CombinedResult<BrandFactory, T1> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrandFactory, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1>(this CombinedResult<T1, BrandFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, WithBrandDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BrandFactory, T1, T2, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2>(this CombinedResult<BrandFactory, T1, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrandFactory, T2, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2>(this CombinedResult<T1, BrandFactory, T2> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrandFactory, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2>(this CombinedResult<T1, T2, BrandFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BrandFactory, T1, T2, T3, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3>(this CombinedResult<BrandFactory, T1, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrandFactory, T2, T3, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3>(this CombinedResult<T1, BrandFactory, T2, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrandFactory, T3, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3>(this CombinedResult<T1, T2, BrandFactory, T3> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BrandFactory, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3>(this CombinedResult<T1, T2, T3, BrandFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BrandFactory, T1, T2, T3, T4, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3, T4>(this CombinedResult<BrandFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BrandFactory, T2, T3, T4, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3, T4>(this CombinedResult<T1, BrandFactory, T2, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BrandFactory, T3, T4, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, BrandFactory, T3, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BrandFactory, T4, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BrandFactory, T4> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BrandFactory, InnerBrandBrandDefinitionFactory> WithBrandDefinition<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BrandFactory> combinedResult, Action<Humidifier.QuickSight.BrandTypes.BrandDefinition> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBrandDefinition(combinedResult.T5, subFactoryAction).T2);
}
