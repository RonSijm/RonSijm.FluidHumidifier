// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupJsonMatchPatternFactory(Action<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern Create()
    {
        var jsonMatchPatternResult = CreateJsonMatchPattern();
        factoryAction?.Invoke(jsonMatchPatternResult);

        return jsonMatchPatternResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern CreateJsonMatchPattern()
    {
        var jsonMatchPatternResult = new Humidifier.WAFv2.RuleGroupTypes.JsonMatchPattern();

        return jsonMatchPatternResult;
    }

} // End Of Class

public static class InnerRuleGroupJsonMatchPatternFactoryExtensions
{
}
