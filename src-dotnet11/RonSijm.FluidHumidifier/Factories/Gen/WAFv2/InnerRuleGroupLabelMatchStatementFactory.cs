// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupLabelMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement Create()
    {
        var labelMatchStatementResult = CreateLabelMatchStatement();
        factoryAction?.Invoke(labelMatchStatementResult);

        return labelMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement CreateLabelMatchStatement()
    {
        var labelMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.LabelMatchStatement();

        return labelMatchStatementResult;
    }

} // End Of Class

public static class InnerRuleGroupLabelMatchStatementFactoryExtensions
{
}
