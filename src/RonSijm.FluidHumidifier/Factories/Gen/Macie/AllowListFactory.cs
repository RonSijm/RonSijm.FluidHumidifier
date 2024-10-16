// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class AllowListFactory(string resourceName = null, Action<Humidifier.Macie.AllowList> factoryAction = null) : ResourceFactory<Humidifier.Macie.AllowList>(resourceName)
{

    internal InnerAllowListCriteriaFactory CriteriaFactory { get; set; }

    protected override Humidifier.Macie.AllowList Create()
    {
        var allowListResult = CreateAllowList();
        factoryAction?.Invoke(allowListResult);

        return allowListResult;
    }

    private Humidifier.Macie.AllowList CreateAllowList()
    {
        var allowListResult = new Humidifier.Macie.AllowList
        {
            GivenName = InputResourceName,
        };

        return allowListResult;
    }
    public override void CreateChildren(Humidifier.Macie.AllowList result)
    {
        base.CreateChildren(result);

        result.Criteria ??= CriteriaFactory?.Build();
    }

} // End Of Class

public static class AllowListFactoryExtensions
{
    public static CombinedResult<AllowListFactory, InnerAllowListCriteriaFactory> WithCriteria(this AllowListFactory parentFactory, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null)
    {
        parentFactory.CriteriaFactory = new InnerAllowListCriteriaFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CriteriaFactory);
    }

    public static CombinedResult<AllowListFactory, T1, InnerAllowListCriteriaFactory> WithCriteria<T1>(this CombinedResult<AllowListFactory, T1> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AllowListFactory, InnerAllowListCriteriaFactory> WithCriteria<T1>(this CombinedResult<T1, AllowListFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<AllowListFactory, T1, T2, InnerAllowListCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<AllowListFactory, T1, T2> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AllowListFactory, T2, InnerAllowListCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, AllowListFactory, T2> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AllowListFactory, InnerAllowListCriteriaFactory> WithCriteria<T1, T2>(this CombinedResult<T1, T2, AllowListFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<AllowListFactory, T1, T2, T3, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<AllowListFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AllowListFactory, T2, T3, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, AllowListFactory, T2, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AllowListFactory, T3, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, AllowListFactory, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AllowListFactory, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3>(this CombinedResult<T1, T2, T3, AllowListFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<AllowListFactory, T1, T2, T3, T4, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<AllowListFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, AllowListFactory, T2, T3, T4, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, AllowListFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, AllowListFactory, T3, T4, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, AllowListFactory, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, AllowListFactory, T4, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AllowListFactory, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, AllowListFactory, InnerAllowListCriteriaFactory> WithCriteria<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AllowListFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.Criteria> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCriteria(combinedResult.T5, subFactoryAction));
}
