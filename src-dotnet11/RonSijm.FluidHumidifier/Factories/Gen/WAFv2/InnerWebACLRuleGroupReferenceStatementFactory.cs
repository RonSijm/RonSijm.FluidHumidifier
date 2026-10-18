// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLRuleGroupReferenceStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement>
{

    protected override Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement Create()
    {
        var ruleGroupReferenceStatementResult = CreateRuleGroupReferenceStatement();
        factoryAction?.Invoke(ruleGroupReferenceStatementResult);

        return ruleGroupReferenceStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement CreateRuleGroupReferenceStatement()
    {
        var ruleGroupReferenceStatementResult = new Humidifier.WAFv2.WebACLTypes.RuleGroupReferenceStatement();

        return ruleGroupReferenceStatementResult;
    }

} // End Of Class

public static class InnerWebACLRuleGroupReferenceStatementFactoryExtensions
{
}
