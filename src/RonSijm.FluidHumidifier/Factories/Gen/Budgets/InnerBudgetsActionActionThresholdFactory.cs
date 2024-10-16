// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionActionThresholdFactory(Action<Humidifier.Budgets.BudgetsActionTypes.ActionThreshold> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.ActionThreshold>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.ActionThreshold Create()
    {
        var actionThresholdResult = CreateActionThreshold();
        factoryAction?.Invoke(actionThresholdResult);

        return actionThresholdResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.ActionThreshold CreateActionThreshold()
    {
        var actionThresholdResult = new Humidifier.Budgets.BudgetsActionTypes.ActionThreshold();

        return actionThresholdResult;
    }

} // End Of Class

public static class InnerBudgetsActionActionThresholdFactoryExtensions
{
}
