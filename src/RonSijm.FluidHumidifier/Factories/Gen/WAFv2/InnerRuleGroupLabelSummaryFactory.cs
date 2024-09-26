// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupLabelSummaryFactory(Action<Humidifier.WAFv2.RuleGroupTypes.LabelSummary> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.LabelSummary>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.LabelSummary Create()
    {
        var labelSummaryResult = CreateLabelSummary();
        factoryAction?.Invoke(labelSummaryResult);

        return labelSummaryResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.LabelSummary CreateLabelSummary()
    {
        var labelSummaryResult = new Humidifier.WAFv2.RuleGroupTypes.LabelSummary();

        return labelSummaryResult;
    }

} // End Of Class

public static class InnerRuleGroupLabelSummaryFactoryExtensions
{
}
