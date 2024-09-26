// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCustomRequestHandlingFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling Create()
    {
        var customRequestHandlingResult = CreateCustomRequestHandling();
        factoryAction?.Invoke(customRequestHandlingResult);

        return customRequestHandlingResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling CreateCustomRequestHandling()
    {
        var customRequestHandlingResult = new Humidifier.WAFv2.RuleGroupTypes.CustomRequestHandling();

        return customRequestHandlingResult;
    }

} // End Of Class

public static class InnerRuleGroupCustomRequestHandlingFactoryExtensions
{
}
