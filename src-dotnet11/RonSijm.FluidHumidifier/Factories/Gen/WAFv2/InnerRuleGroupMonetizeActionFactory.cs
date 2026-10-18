// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupMonetizeActionFactory(Action<Humidifier.WAFv2.RuleGroupTypes.MonetizeAction> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.MonetizeAction>
{

    protected override Humidifier.WAFv2.RuleGroupTypes.MonetizeAction Create()
    {
        var monetizeActionResult = CreateMonetizeAction();
        factoryAction?.Invoke(monetizeActionResult);

        return monetizeActionResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.MonetizeAction CreateMonetizeAction()
    {
        var monetizeActionResult = new Humidifier.WAFv2.RuleGroupTypes.MonetizeAction();

        return monetizeActionResult;
    }

} // End Of Class

public static class InnerRuleGroupMonetizeActionFactoryExtensions
{
}
