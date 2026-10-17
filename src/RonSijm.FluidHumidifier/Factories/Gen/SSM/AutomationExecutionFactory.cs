// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class AutomationExecutionFactory(string resourceName = null, Action<Humidifier.SSM.AutomationExecution> factoryAction = null) : ResourceFactory<Humidifier.SSM.AutomationExecution>(resourceName)
{

    protected override Humidifier.SSM.AutomationExecution Create()
    {
        var automationExecutionResult = CreateAutomationExecution();
        factoryAction?.Invoke(automationExecutionResult);

        return automationExecutionResult;
    }

    private Humidifier.SSM.AutomationExecution CreateAutomationExecution()
    {
        var automationExecutionResult = new Humidifier.SSM.AutomationExecution
        {
            GivenName = InputResourceName,
        };

        return automationExecutionResult;
    }

} // End Of Class

public static class AutomationExecutionFactoryExtensions
{
}
