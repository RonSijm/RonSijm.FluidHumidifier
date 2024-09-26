// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.InspectorV2;

public class FilterFactory(string resourceName = null, Action<Humidifier.InspectorV2.Filter> factoryAction = null) : ResourceFactory<Humidifier.InspectorV2.Filter>(resourceName)
{

    internal InnerFilterFilterCriteriaFactory FilterCriteriaFactory { get; set; }

    protected override Humidifier.InspectorV2.Filter Create()
    {
        var filterResult = CreateFilter();
        factoryAction?.Invoke(filterResult);

        return filterResult;
    }

    private Humidifier.InspectorV2.Filter CreateFilter()
    {
        var filterResult = new Humidifier.InspectorV2.Filter
        {
            GivenName = InputResourceName,
        };

        return filterResult;
    }
    public override void CreateChildren(Humidifier.InspectorV2.Filter result)
    {
        base.CreateChildren(result);

        result.FilterCriteria ??= FilterCriteriaFactory?.Build();
    }

} // End Of Class

public static class FilterFactoryExtensions
{
    public static CombinedResult<FilterFactory, InnerFilterFilterCriteriaFactory> WithFilterCriteria(this FilterFactory parentFactory, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null)
    {
        parentFactory.FilterCriteriaFactory = new InnerFilterFilterCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FilterCriteriaFactory);
    }

    public static CombinedResult<FilterFactory, T1, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1>(this CombinedResult<FilterFactory, T1> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1>(this CombinedResult<T1, FilterFactory> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilterCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2>(this CombinedResult<FilterFactory, T1, T2> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2>(this CombinedResult<T1, FilterFactory, T2> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2>(this CombinedResult<T1, T2, FilterFactory> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3>(this CombinedResult<FilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3>(this CombinedResult<T1, FilterFactory, T2, T3> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3>(this CombinedResult<T1, T2, FilterFactory, T3> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, FilterFactory> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FilterFactory, T1, T2, T3, T4, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3, T4>(this CombinedResult<FilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FilterFactory, T2, T3, T4, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3, T4>(this CombinedResult<T1, FilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FilterFactory, T3, T4, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, FilterFactory, T3, T4> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FilterFactory, T4, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FilterFactory, T4> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FilterFactory, InnerFilterFilterCriteriaFactory> WithFilterCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FilterFactory> combinedResult, Action<Humidifier.InspectorV2.FilterTypes.FilterCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilterCriteria(combinedResult.T5, subFactoryAction));
}
