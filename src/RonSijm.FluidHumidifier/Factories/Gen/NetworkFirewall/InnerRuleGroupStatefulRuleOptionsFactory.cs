// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.NetworkFirewall;

public class InnerRuleGroupStatefulRuleOptionsFactory(Action<Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions> factoryAction = null) : SubResourceFactory<Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions>
{

    protected override Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions Create()
    {
        var statefulRuleOptionsResult = CreateStatefulRuleOptions();
        factoryAction?.Invoke(statefulRuleOptionsResult);

        return statefulRuleOptionsResult;
    }

    private Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions CreateStatefulRuleOptions()
    {
        var statefulRuleOptionsResult = new Humidifier.NetworkFirewall.RuleGroupTypes.StatefulRuleOptions();

        return statefulRuleOptionsResult;
    }

} // End Of Class

public static class InnerRuleGroupStatefulRuleOptionsFactoryExtensions
{
}
