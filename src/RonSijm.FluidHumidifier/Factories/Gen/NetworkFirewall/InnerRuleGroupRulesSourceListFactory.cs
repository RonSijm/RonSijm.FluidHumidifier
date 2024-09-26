// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupRulesSourceListFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList Create()
    {
        var rulesSourceListResult = CreateRulesSourceList();
        factoryAction?.Invoke(rulesSourceListResult);

        return rulesSourceListResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList CreateRulesSourceList()
    {
        var rulesSourceListResult = new Humidifier.NetworkFirewall.RuleGroupTypes.RulesSourceList();

        return rulesSourceListResult;
    }

} // End Of Class

public static class InnerRuleGroupRulesSourceListFactoryExtensions
{
}
