// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupHeaderMatchPatternFactory(Action<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern Create()
    {
        var headerMatchPatternResult = CreateHeaderMatchPattern();
        factoryAction?.Invoke(headerMatchPatternResult);

        return headerMatchPatternResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern CreateHeaderMatchPattern()
    {
        var headerMatchPatternResult = new Humidifier.WAFv2.RuleGroupTypes.HeaderMatchPattern();

        return headerMatchPatternResult;
    }

} // End Of Class

public static class InnerRuleGroupHeaderMatchPatternFactoryExtensions
{
}
