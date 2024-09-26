// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleAutomationRulesFindingFiltersFactory(Action<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters>
{

    protected override Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters Create()
    {
        var automationRulesFindingFiltersResult = CreateAutomationRulesFindingFilters();
        factoryAction?.Invoke(automationRulesFindingFiltersResult);

        return automationRulesFindingFiltersResult;
    }

    private Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters CreateAutomationRulesFindingFilters()
    {
        var automationRulesFindingFiltersResult = new Humidifier.SecurityHub.AutomationRuleTypes.AutomationRulesFindingFilters();

        return automationRulesFindingFiltersResult;
    }

} // End Of Class

public static class InnerAutomationRuleAutomationRulesFindingFiltersFactoryExtensions
{
}
