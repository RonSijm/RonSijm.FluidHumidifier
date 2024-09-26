// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupOrStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.OrStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.OrStatement>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.OrStatement Create()
    {
        var orStatementResult = CreateOrStatement();
        factoryAction?.Invoke(orStatementResult);

        return orStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.OrStatement CreateOrStatement()
    {
        var orStatementResult = new Humidifier.WAFv2.RuleGroupTypes.OrStatement();

        return orStatementResult;
    }

} // End Of Class

public static class InnerRuleGroupOrStatementFactoryExtensions
{
}
