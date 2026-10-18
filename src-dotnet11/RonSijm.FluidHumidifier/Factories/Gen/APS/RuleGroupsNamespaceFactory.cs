// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.APS;

public class RuleGroupsNamespaceFactory(string resourceName = null, Action<Humidifier.APS.RuleGroupsNamespace> factoryAction = null) : ResourceFactory<Humidifier.APS.RuleGroupsNamespace>(resourceName)
{

    protected override Humidifier.APS.RuleGroupsNamespace Create()
    {
        var ruleGroupsNamespaceResult = CreateRuleGroupsNamespace();
        factoryAction?.Invoke(ruleGroupsNamespaceResult);

        return ruleGroupsNamespaceResult;
    }

    private Humidifier.APS.RuleGroupsNamespace CreateRuleGroupsNamespace()
    {
        var ruleGroupsNamespaceResult = new Humidifier.APS.RuleGroupsNamespace
        {
            GivenName = InputResourceName,
        };

        return ruleGroupsNamespaceResult;
    }

} // End Of Class

public static class RuleGroupsNamespaceFactoryExtensions
{
}
