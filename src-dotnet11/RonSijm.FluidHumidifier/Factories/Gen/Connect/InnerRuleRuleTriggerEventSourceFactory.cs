// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerRuleRuleTriggerEventSourceFactory(Action<Humidifier.Connect.RuleTypes.RuleTriggerEventSource> factoryAction = null) : SubResourceFactory<Humidifier.Connect.RuleTypes.RuleTriggerEventSource>
{

    protected override Humidifier.Connect.RuleTypes.RuleTriggerEventSource Create()
    {
        var ruleTriggerEventSourceResult = CreateRuleTriggerEventSource();
        factoryAction?.Invoke(ruleTriggerEventSourceResult);

        return ruleTriggerEventSourceResult;
    }

    private Humidifier.Connect.RuleTypes.RuleTriggerEventSource CreateRuleTriggerEventSource()
    {
        var ruleTriggerEventSourceResult = new Humidifier.Connect.RuleTypes.RuleTriggerEventSource();

        return ruleTriggerEventSourceResult;
    }

} // End Of Class

public static class InnerRuleRuleTriggerEventSourceFactoryExtensions
{
}
