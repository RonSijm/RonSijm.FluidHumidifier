// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class InnerSafetyRuleRuleConfigFactory(Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig>
{

    protected override Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig Create()
    {
        var ruleConfigResult = CreateRuleConfig();
        factoryAction?.Invoke(ruleConfigResult);

        return ruleConfigResult;
    }

    private Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig CreateRuleConfig()
    {
        var ruleConfigResult = new Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig();

        return ruleConfigResult;
    }

} // End Of Class

public static class InnerSafetyRuleRuleConfigFactoryExtensions
{
}
