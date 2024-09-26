// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InsightFactory(string resourceName = null, Action<Humidifier.SecurityHub.Insight> factoryAction = null) : ResourceFactory<Humidifier.SecurityHub.Insight>(resourceName)
{

    internal InnerInsightAwsSecurityFindingFiltersFactory FiltersFactory { get; set; }

    protected override Humidifier.SecurityHub.Insight Create()
    {
        var insightResult = CreateInsight();
        factoryAction?.Invoke(insightResult);

        return insightResult;
    }

    private Humidifier.SecurityHub.Insight CreateInsight()
    {
        var insightResult = new Humidifier.SecurityHub.Insight
        {
            GivenName = InputResourceName,
        };

        return insightResult;
    }
    public override void CreateChildren(Humidifier.SecurityHub.Insight result)
    {
        base.CreateChildren(result);

        result.Filters ??= FiltersFactory?.Build();
    }

} // End Of Class

public static class InsightFactoryExtensions
{
    public static CombinedResult<InsightFactory, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters(this InsightFactory parentFactory, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null)
    {
        parentFactory.FiltersFactory = new InnerInsightAwsSecurityFindingFiltersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FiltersFactory);
    }

    public static CombinedResult<InsightFactory, T1, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1>(this CombinedResult<InsightFactory, T1> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightFactory, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1>(this CombinedResult<T1, InsightFactory> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InsightFactory, T1, T2, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2>(this CombinedResult<InsightFactory, T1, T2> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightFactory, T2, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2>(this CombinedResult<T1, InsightFactory, T2> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightFactory, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2>(this CombinedResult<T1, T2, InsightFactory> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InsightFactory, T1, T2, T3, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<InsightFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightFactory, T2, T3, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, InsightFactory, T2, T3> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightFactory, T3, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, InsightFactory, T3> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InsightFactory, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3>(this CombinedResult<T1, T2, T3, InsightFactory> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InsightFactory, T1, T2, T3, T4, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<InsightFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightFactory, T2, T3, T4, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, InsightFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightFactory, T3, T4, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, InsightFactory, T3, T4> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InsightFactory, T4, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InsightFactory, T4> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InsightFactory, InnerInsightAwsSecurityFindingFiltersFactory> WithFilters<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InsightFactory> combinedResult, Action<Humidifier.SecurityHub.InsightTypes.AwsSecurityFindingFilters> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFilters(combinedResult.T5, subFactoryAction));
}
