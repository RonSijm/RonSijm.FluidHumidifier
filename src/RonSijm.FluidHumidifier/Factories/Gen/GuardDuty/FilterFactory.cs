// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.GuardDuty;

public class FilterFactory(string resourceName = null, Action<Humidifier.GuardDuty.Filter> factoryAction = null) : ResourceFactory<Humidifier.GuardDuty.Filter>(resourceName)
{

    internal List<InnerFilterTagItemFactory> TagsFactories { get; set; } = [];

    internal InnerFilterFindingCriteriaFactory FindingCriteriaFactory { get; set; }

    protected override Humidifier.GuardDuty.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.GuardDuty.Filter CreateFilter()
    {
        var filterResult = new Humidifier.GuardDuty.Filter
        {
            GivenName = InputResourceName,
        };

        return filterResult;
    }
    public override void CreateChildren(Humidifier.GuardDuty.Filter result)
    {
        base.CreateChildren(result);

        result.Tags = TagsFactories.Any() ? TagsFactories.Select(x => x.Build()).ToList() : null;
        result.FindingCriteria ??= FindingCriteriaFactory?.Build();
    }

} // End Of Class

public static class FilterFactoryExtensions
{
    public static CombinedResult<FilterFactory, InnerFilterTagItemFactory> WithTags(this FilterFactory parentFactory, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null)
    {
        var factory = new InnerFilterTagItemFactory(subFactoryAction);
        parentFactory.TagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<FilterFactory, InnerFilterFindingCriteriaFactory> WithFindingCriteria(this FilterFactory parentFactory, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null)
    {
        parentFactory.FindingCriteriaFactory = new InnerFilterFindingCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FindingCriteriaFactory);
    }

    public static CombinedResult<FilterFactory, T1, InnerFilterTagItemFactory> WithTags<T1>(this CombinedResult<FilterFactory, T1> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, InnerFilterTagItemFactory> WithTags<T1>(this CombinedResult<T1, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, InnerFilterTagItemFactory> WithTags<T1, T2>(this CombinedResult<FilterFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, InnerFilterTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, FilterFactory, T2> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, InnerFilterTagItemFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, InnerFilterTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<FilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, InnerFilterTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, FilterFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, InnerFilterTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, FilterFactory, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, InnerFilterTagItemFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, T4, InnerFilterTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<FilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, T4, InnerFilterTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, FilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, T4, InnerFilterTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, FilterFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, T4, InnerFilterTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FilterFactory, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FilterFactory, InnerFilterTagItemFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.TagItem> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1>(this CombinedResult<FilterFactory, T1> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1>(this CombinedResult<T1, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<FilterFactory, T1, T2> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<T1, FilterFactory, T2> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<T1, T2, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<FilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, FilterFactory, T2, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, FilterFactory, T3> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, T4, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<FilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, T4, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, FilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, T4, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, FilterFactory, T3, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, T4, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FilterFactory, T4> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FilterFactory, InnerFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FilterFactory> combinedResult, Action<Humidifier.GuardDuty.FilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T5, subFactoryAction));
}
