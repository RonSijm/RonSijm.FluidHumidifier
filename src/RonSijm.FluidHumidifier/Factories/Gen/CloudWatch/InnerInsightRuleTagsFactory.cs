// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InnerInsightRuleTagsFactory(Action<Humidifier.CloudWatch.InsightRuleTypes.Tags> factoryAction = null) : SubResourceFactory<Humidifier.CloudWatch.InsightRuleTypes.Tags>
{

    protected override Humidifier.CloudWatch.InsightRuleTypes.Tags Create()
    {
        var tagsResult = CreateTags();
        factoryAction?.Invoke(tagsResult);

        return tagsResult;
    }

    private Humidifier.CloudWatch.InsightRuleTypes.Tags CreateTags()
    {
        var tagsResult = new Humidifier.CloudWatch.InsightRuleTypes.Tags();

        return tagsResult;
    }

} // End Of Class

public static class InnerInsightRuleTagsFactoryExtensions
{
}
