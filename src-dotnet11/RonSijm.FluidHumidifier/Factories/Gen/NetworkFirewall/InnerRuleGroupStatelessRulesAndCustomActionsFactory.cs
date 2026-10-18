// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupStatelessRulesAndCustomActionsFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions Create()
    {
        var statelessRulesAndCustomActionsResult = CreateStatelessRulesAndCustomActions();
        factoryAction?.Invoke(statelessRulesAndCustomActionsResult);

        return statelessRulesAndCustomActionsResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions CreateStatelessRulesAndCustomActions()
    {
        var statelessRulesAndCustomActionsResult = new Humidifier.NetworkFirewall.RuleGroupTypes.StatelessRulesAndCustomActions();

        return statelessRulesAndCustomActionsResult;
    }

} // End Of Class

public static class InnerRuleGroupStatelessRulesAndCustomActionsFactoryExtensions
{
}
