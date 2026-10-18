// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ECR;

public class PullThroughCacheRuleFactory(string resourceName = null, Action<Humidifier.ECR.PullThroughCacheRule> factoryAction = null) : ResourceFactory<Humidifier.ECR.PullThroughCacheRule>(resourceName)
{

    protected override Humidifier.ECR.PullThroughCacheRule Create()
    {
        var pullThroughCacheRuleResult = CreatePullThroughCacheRule();
        factoryAction?.Invoke(pullThroughCacheRuleResult);

        return pullThroughCacheRuleResult;
    }

    private Humidifier.ECR.PullThroughCacheRule CreatePullThroughCacheRule()
    {
        var pullThroughCacheRuleResult = new Humidifier.ECR.PullThroughCacheRule
        {
            GivenName = InputResourceName,
        };

        return pullThroughCacheRuleResult;
    }

} // End Of Class

public static class PullThroughCacheRuleFactoryExtensions
{
}
