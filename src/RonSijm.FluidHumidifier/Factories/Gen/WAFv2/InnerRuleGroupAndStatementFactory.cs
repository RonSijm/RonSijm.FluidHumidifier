// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupAndStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.AndStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.AndStatement>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.AndStatement Create()
    {
        var andStatementResult = CreateAndStatement();
        factoryAction?.Invoke(andStatementResult);

        return andStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.AndStatement CreateAndStatement()
    {
        var andStatementResult = new Humidifier.WAFv2.RuleGroupTypes.AndStatement();

        return andStatementResult;
    }

} // End Of Class

public static class InnerRuleGroupAndStatementFactoryExtensions
{
}
