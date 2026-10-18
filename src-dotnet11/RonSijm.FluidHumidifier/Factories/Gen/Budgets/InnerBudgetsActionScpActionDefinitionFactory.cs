// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionScpActionDefinitionFactory(Action<Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition Create()
    {
        var scpActionDefinitionResult = CreateScpActionDefinition();
        factoryAction?.Invoke(scpActionDefinitionResult);

        return scpActionDefinitionResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition CreateScpActionDefinition()
    {
        var scpActionDefinitionResult = new Humidifier.Budgets.BudgetsActionTypes.ScpActionDefinition();

        return scpActionDefinitionResult;
    }

} // End Of Class

public static class InnerBudgetsActionScpActionDefinitionFactoryExtensions
{
}
