// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class InnerSafetyRuleAssertionRuleFactory(Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule>
{

    protected override Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule Create()
    {
        var assertionRuleResult = CreateAssertionRule();
        factoryAction?.Invoke(assertionRuleResult);

        return assertionRuleResult;
    }

    private Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule CreateAssertionRule()
    {
        var assertionRuleResult = new Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule();

        return assertionRuleResult;
    }

} // End Of Class

public static class InnerSafetyRuleAssertionRuleFactoryExtensions
{
}
