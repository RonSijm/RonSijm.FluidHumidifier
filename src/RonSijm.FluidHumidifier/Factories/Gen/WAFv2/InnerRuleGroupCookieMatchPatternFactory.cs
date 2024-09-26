// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCookieMatchPatternFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern Create()
    {
        var cookieMatchPatternResult = CreateCookieMatchPattern();
        factoryAction?.Invoke(cookieMatchPatternResult);

        return cookieMatchPatternResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern CreateCookieMatchPattern()
    {
        var cookieMatchPatternResult = new Humidifier.WAFv2.RuleGroupTypes.CookieMatchPattern();

        return cookieMatchPatternResult;
    }

} // End Of Class

public static class InnerRuleGroupCookieMatchPatternFactoryExtensions
{
}
