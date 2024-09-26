// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InsightRuleFactory(string resourceName = null, Action<Humidifier.CloudWatch.InsightRule> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.InsightRule>(resourceName)
{

    internal InnerInsightRuleTagsFactory TagsFactory { get; set; }

    protected override Humidifier.CloudWatch.InsightRule Create()
    {
        var insightRuleResult = CreateInsightRule();
        factoryAction?.Invoke(insightRuleResult);

        return insightRuleResult;
    }

    private Humidifier.CloudWatch.InsightRule CreateInsightRule()
    {
        var insightRuleResult = new Humidifier.CloudWatch.InsightRule
        {
            GivenName = InputResourceName,
        };

        return insightRuleResult;
    }
    public override void CreateChildren(Humidifier.CloudWatch.InsightRule result)
    {
        base.CreateChildren(result);

        result.Tags ??= TagsFactory?.Build();
    }

} // End Of Class

public static class InsightRuleFactoryExtensions
{
    public static CombinedResult<InsightRuleFactory, InnerInsightRuleTagsFactory> WithTags(this InsightRuleFactory parentFactory, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null)
    {
        parentFactory.TagsFactory = new InnerInsightRuleTagsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TagsFactory);
    }

    public static CombinedResult<InsightRuleFactory, T1, InnerInsightRuleTagsFactory> WithTags<T1>(this CombinedResult<InsightRuleFactory, T1> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightRuleFactory, InnerInsightRuleTagsFactory> WithTags<T1>(this CombinedResult<T1, InsightRuleFactory> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InsightRuleFactory, T1, T2, InnerInsightRuleTagsFactory> WithTags<T1, T2>(this CombinedResult<InsightRuleFactory, T1, T2> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightRuleFactory, T2, InnerInsightRuleTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, InsightRuleFactory, T2> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightRuleFactory, InnerInsightRuleTagsFactory> WithTags<T1, T2>(this CombinedResult<T1, T2, InsightRuleFactory> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InsightRuleFactory, T1, T2, T3, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<InsightRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightRuleFactory, T2, T3, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, InsightRuleFactory, T2, T3> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightRuleFactory, T3, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, InsightRuleFactory, T3> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InsightRuleFactory, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, InsightRuleFactory> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InsightRuleFactory, T1, T2, T3, T4, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<InsightRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InsightRuleFactory, T2, T3, T4, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, InsightRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InsightRuleFactory, T3, T4, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, InsightRuleFactory, T3, T4> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InsightRuleFactory, T4, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InsightRuleFactory, T4> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InsightRuleFactory, InnerInsightRuleTagsFactory> WithTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InsightRuleFactory> combinedResult, Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTags(combinedResult.T5, subFactoryAction));
}
