// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityHub;

public class InnerAutomationRuleV2AutomationRulesFindingFieldsUpdateV2Factory(Action<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2> factoryAction = null) : SubResourceFactory<Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2>
{

    protected override Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2 Create()
    {
        var automationRulesFindingFieldsUpdateV2Result = CreateAutomationRulesFindingFieldsUpdateV2();
        factoryAction?.Invoke(automationRulesFindingFieldsUpdateV2Result);

        return automationRulesFindingFieldsUpdateV2Result;
    }

    private Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2 CreateAutomationRulesFindingFieldsUpdateV2()
    {
        var automationRulesFindingFieldsUpdateV2Result = new Humidifier.SecurityHub.AutomationRuleV2Types.AutomationRulesFindingFieldsUpdateV2();

        return automationRulesFindingFieldsUpdateV2Result;
    }

} // End Of Class

public static class InnerAutomationRuleV2AutomationRulesFindingFieldsUpdateV2FactoryExtensions
{
}
