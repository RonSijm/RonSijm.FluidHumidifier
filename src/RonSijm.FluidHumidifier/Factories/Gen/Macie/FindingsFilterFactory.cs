// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class FindingsFilterFactory(string resourceName = null, Action<Humidifier.Macie.FindingsFilter> factoryAction = null) : ResourceFactory<Humidifier.Macie.FindingsFilter>(resourceName)
{

    internal InnerFindingsFilterFindingCriteriaFactory FindingCriteriaFactory { get; set; }

    protected override Humidifier.Macie.FindingsFilter Create()
    {
        var findingsFilterResult = CreateFindingsFilter();
        factoryAction?.Invoke(findingsFilterResult);

        return findingsFilterResult;
    }

    private Humidifier.Macie.FindingsFilter CreateFindingsFilter()
    {
        var findingsFilterResult = new Humidifier.Macie.FindingsFilter
        {
            GivenName = InputResourceName,
        };

        return findingsFilterResult;
    }
    public override void CreateChildren(Humidifier.Macie.FindingsFilter result)
    {
        base.CreateChildren(result);

        result.FindingCriteria ??= FindingCriteriaFactory?.Build();
    }

} // End Of Class

public static class FindingsFilterFactoryExtensions
{
    public static CombinedResult<FindingsFilterFactory, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria(this FindingsFilterFactory parentFactory, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null)
    {
        parentFactory.FindingCriteriaFactory = new InnerFindingsFilterFindingCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FindingCriteriaFactory);
    }

    public static CombinedResult<FindingsFilterFactory, T1, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1>(this CombinedResult<FindingsFilterFactory, T1> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FindingsFilterFactory, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1>(this CombinedResult<T1, FindingsFilterFactory> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<FindingsFilterFactory, T1, T2, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<FindingsFilterFactory, T1, T2> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FindingsFilterFactory, T2, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<T1, FindingsFilterFactory, T2> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FindingsFilterFactory, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2>(this CombinedResult<T1, T2, FindingsFilterFactory> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<FindingsFilterFactory, T1, T2, T3, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<FindingsFilterFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FindingsFilterFactory, T2, T3, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, FindingsFilterFactory, T2, T3> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FindingsFilterFactory, T3, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, FindingsFilterFactory, T3> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FindingsFilterFactory, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, FindingsFilterFactory> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<FindingsFilterFactory, T1, T2, T3, T4, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<FindingsFilterFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, FindingsFilterFactory, T2, T3, T4, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, FindingsFilterFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, FindingsFilterFactory, T3, T4, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, FindingsFilterFactory, T3, T4> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, FindingsFilterFactory, T4, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, FindingsFilterFactory, T4> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, FindingsFilterFactory, InnerFindingsFilterFindingCriteriaFactory> WithFindingCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, FindingsFilterFactory> combinedResult, Action<Humidifier.Macie.FindingsFilterTypes.FindingCriteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFindingCriteria(combinedResult.T5, subFactoryAction));
}
