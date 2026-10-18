// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.CloudWatch;

public class InsightRuleFactory(string resourceName = null, Action<Humidifier.CloudWatch.InsightRule> factoryAction = null) : ResourceFactory<Humidifier.CloudWatch.InsightRule>(resourceName)
{

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

} // End Of Class

public static class InsightRuleFactoryExtensions
{
}
