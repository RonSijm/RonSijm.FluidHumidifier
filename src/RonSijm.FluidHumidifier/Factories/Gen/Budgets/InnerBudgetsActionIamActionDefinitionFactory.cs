// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionIamActionDefinitionFactory(Action<Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition Create()
    {
        var iamActionDefinitionResult = CreateIamActionDefinition();
        factoryAction?.Invoke(iamActionDefinitionResult);

        return iamActionDefinitionResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition CreateIamActionDefinition()
    {
        var iamActionDefinitionResult = new Humidifier.Budgets.BudgetsActionTypes.IamActionDefinition();

        return iamActionDefinitionResult;
    }

} // End Of Class

public static class InnerBudgetsActionIamActionDefinitionFactoryExtensions
{
}
