// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleSeverityUpdateFactory(Action<Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate>
{

    protected override Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate Create()
    {
        var severityUpdateResult = CreateSeverityUpdate();
        factoryAction?.Invoke(severityUpdateResult);

        return severityUpdateResult;
    }

    private Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate CreateSeverityUpdate()
    {
        var severityUpdateResult = new Humidifier.SecurityHub.AutomationRuleTypes.SeverityUpdate();

        return severityUpdateResult;
    }

} // End Of Class

public static class InnerAutomationRuleSeverityUpdateFactoryExtensions
{
}
