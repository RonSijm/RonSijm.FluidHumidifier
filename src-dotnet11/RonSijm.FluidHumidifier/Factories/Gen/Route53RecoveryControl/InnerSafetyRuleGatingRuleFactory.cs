// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class InnerSafetyRuleGatingRuleFactory(Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> factoryAction = null) : SubResourceFactory<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule>
{

    protected override Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule Create()
    {
        var gatingRuleResult = CreateGatingRule();
        factoryAction?.Invoke(gatingRuleResult);

        return gatingRuleResult;
    }

    private Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule CreateGatingRule()
    {
        var gatingRuleResult = new Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule();

        return gatingRuleResult;
    }

} // End Of Class

public static class InnerSafetyRuleGatingRuleFactoryExtensions
{
}
