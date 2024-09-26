// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupRuleVariablesFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables Create()
    {
        var ruleVariablesResult = CreateRuleVariables();
        factoryAction?.Invoke(ruleVariablesResult);

        return ruleVariablesResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables CreateRuleVariables()
    {
        var ruleVariablesResult = new Humidifier.NetworkFirewall.RuleGroupTypes.RuleVariables();

        return ruleVariablesResult;
    }

} // End Of Class

public static class InnerRuleGroupRuleVariablesFactoryExtensions
{
}
