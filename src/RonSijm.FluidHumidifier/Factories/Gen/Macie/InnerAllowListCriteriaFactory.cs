// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Macie;

public class InnerAllowListCriteriaFactory(Action<Humidifier.Macie.AllowListTypes.Criteria> factoryAction = null) : SubResourceFactory<Humidifier.Macie.AllowListTypes.Criteria>
{

    internal InnerAllowListS3WordsListFactory S3WordsListFactory { get; set; }

    protected override Humidifier.Macie.AllowListTypes.Criteria Create()
    {
        var criteriaResult = CreateCriteria();
        factoryAction?.Invoke(criteriaResult);

        return criteriaResult;
    }

    private Humidifier.Macie.AllowListTypes.Criteria CreateCriteria()
    {
        var criteriaResult = new Humidifier.Macie.AllowListTypes.Criteria();

        return criteriaResult;
    }
    public override void CreateChildren(Humidifier.Macie.AllowListTypes.Criteria result)
    {
        base.CreateChildren(result);

        result.S3WordsList ??= S3WordsListFactory?.Build();
    }

} // End Of Class

public static class InnerAllowListCriteriaFactoryExtensions
{
    public static CombinedResult<InnerAllowListCriteriaFactory, InnerAllowListS3WordsListFactory> WithS3WordsList(this InnerAllowListCriteriaFactory parentFactory, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null)
    {
        parentFactory.S3WordsListFactory = new InnerAllowListS3WordsListFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.S3WordsListFactory);
    }

    public static CombinedResult<InnerAllowListCriteriaFactory, T1, InnerAllowListS3WordsListFactory> WithS3WordsList<T1>(this CombinedResult<InnerAllowListCriteriaFactory, T1> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3WordsList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAllowListCriteriaFactory, InnerAllowListS3WordsListFactory> WithS3WordsList<T1>(this CombinedResult<T1, InnerAllowListCriteriaFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, WithS3WordsList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerAllowListCriteriaFactory, T1, T2, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2>(this CombinedResult<InnerAllowListCriteriaFactory, T1, T2> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAllowListCriteriaFactory, T2, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2>(this CombinedResult<T1, InnerAllowListCriteriaFactory, T2> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAllowListCriteriaFactory, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2>(this CombinedResult<T1, T2, InnerAllowListCriteriaFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerAllowListCriteriaFactory, T1, T2, T3, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3>(this CombinedResult<InnerAllowListCriteriaFactory, T1, T2, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAllowListCriteriaFactory, T2, T3, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3>(this CombinedResult<T1, InnerAllowListCriteriaFactory, T2, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAllowListCriteriaFactory, T3, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3>(this CombinedResult<T1, T2, InnerAllowListCriteriaFactory, T3> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAllowListCriteriaFactory, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerAllowListCriteriaFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerAllowListCriteriaFactory, T1, T2, T3, T4, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3, T4>(this CombinedResult<InnerAllowListCriteriaFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerAllowListCriteriaFactory, T2, T3, T4, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3, T4>(this CombinedResult<T1, InnerAllowListCriteriaFactory, T2, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerAllowListCriteriaFactory, T3, T4, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerAllowListCriteriaFactory, T3, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerAllowListCriteriaFactory, T4, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerAllowListCriteriaFactory, T4> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerAllowListCriteriaFactory, InnerAllowListS3WordsListFactory> WithS3WordsList<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerAllowListCriteriaFactory> combinedResult, Action<Humidifier.Macie.AllowListTypes.S3WordsList> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithS3WordsList(combinedResult.T5, subFactoryAction));
}
