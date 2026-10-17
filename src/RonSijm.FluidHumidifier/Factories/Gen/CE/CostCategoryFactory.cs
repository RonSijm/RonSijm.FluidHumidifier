// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CE;

public class CostCategoryFactory(string resourceName = null, Action<Humidifier.CE.CostCategory> factoryAction = null) : ResourceFactory<Humidifier.CE.CostCategory>(resourceName)
{

    internal List<InnerCostCategoryResourceTagFactory> TagsFactories { get; set; } = [];

    protected override Humidifier.CE.CostCategory Create()
    {
        var costCategoryResult = CreateCostCategory();
        factoryAction?.Invoke(costCategoryResult);

        return costCategoryResult;
    }

    private Humidifier.CE.CostCategory CreateCostCategory()
    {
        var costCategoryResult = new Humidifier.CE.CostCategory
        {
            GivenName = InputResourceName,
        };

        return costCategoryResult;
    }
    public override void CreateChildren(Humidifier.CE.CostCategory result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class CostCategoryFactoryExtensions
{
    public static CombinedResult<CostCategoryFactory, InnerCostCategoryResourceTagFactory> WithTags(this CostCategoryFactory parentFactory, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerCostCategoryResourceTagFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<CostCategoryFactory, T1, InnerCostCategoryResourceTagFactory> WithTags<T1>(this CombinedResult<CostCategoryFactory, T1> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CostCategoryFactory, InnerCostCategoryResourceTagFactory> WithTags<T1>(this CombinedResult<T1, CostCategoryFactory> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<CostCategoryFactory, T1, T2, InnerCostCategoryResourceTagFactory> WithTags<T1, T2>(this CombinedResult<CostCategoryFactory, T1, T2> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CostCategoryFactory, T2, InnerCostCategoryResourceTagFactory> WithTags<T1, T2>(this CombinedResult<T1, CostCategoryFactory, T2> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CostCategoryFactory, InnerCostCategoryResourceTagFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, CostCategoryFactory> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<CostCategoryFactory, T1, T2, T3, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<CostCategoryFactory, T1, T2, T3> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CostCategoryFactory, T2, T3, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, CostCategoryFactory, T2, T3> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CostCategoryFactory, T3, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, CostCategoryFactory, T3> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CostCategoryFactory, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, CostCategoryFactory> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<CostCategoryFactory, T1, T2, T3, T4, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<CostCategoryFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, CostCategoryFactory, T2, T3, T4, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, CostCategoryFactory, T2, T3, T4> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, CostCategoryFactory, T3, T4, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, CostCategoryFactory, T3, T4> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, CostCategoryFactory, T4, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, CostCategoryFactory, T4> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, CostCategoryFactory, InnerCostCategoryResourceTagFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, CostCategoryFactory> combinedResult, Action<Humidifier.CE.CostCategoryTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction).T2);
}
