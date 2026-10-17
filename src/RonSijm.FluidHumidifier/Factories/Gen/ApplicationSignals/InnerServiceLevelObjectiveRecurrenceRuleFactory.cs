// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApplicationSignals;

public class InnerServiceLevelObjectiveRecurrenceRuleFactory(Action<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule> factoryAction = null) : SubResourceFactory<Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule>
{

    protected override Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule Create()
    {
        var recurrenceRuleResult = CreateRecurrenceRule();
        factoryAction?.Invoke(recurrenceRuleResult);

        return recurrenceRuleResult;
    }

    private Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule CreateRecurrenceRule()
    {
        var recurrenceRuleResult = new Humidifier.ApplicationSignals.ServiceLevelObjectiveTypes.RecurrenceRule();

        return recurrenceRuleResult;
    }

} // End Of Class

public static class InnerServiceLevelObjectiveRecurrenceRuleFactoryExtensions
{
}
