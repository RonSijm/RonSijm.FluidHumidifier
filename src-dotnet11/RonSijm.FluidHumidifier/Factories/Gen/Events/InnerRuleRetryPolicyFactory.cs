// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Events;

public class InnerRuleRetryPolicyFactory(Action<Humidifier.Events.RuleTypes.RetryPolicy> factoryAction = null) : SubResourceFactory<Humidifier.Events.RuleTypes.RetryPolicy>
{

    protected override Humidifier.Events.RuleTypes.RetryPolicy Create()
    {
        var retryPolicyResult = CreateRetryPolicy();
        factoryAction?.Invoke(retryPolicyResult);

        return retryPolicyResult;
    }

    private Humidifier.Events.RuleTypes.RetryPolicy CreateRetryPolicy()
    {
        var retryPolicyResult = new Humidifier.Events.RuleTypes.RetryPolicy();

        return retryPolicyResult;
    }

} // End Of Class

public static class InnerRuleRetryPolicyFactoryExtensions
{
}
