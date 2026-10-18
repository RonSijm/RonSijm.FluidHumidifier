// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetsActionSsmActionDefinitionFactory(Action<Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition>
{

    protected override Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition Create()
    {
        var ssmActionDefinitionResult = CreateSsmActionDefinition();
        factoryAction?.Invoke(ssmActionDefinitionResult);

        return ssmActionDefinitionResult;
    }

    private Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition CreateSsmActionDefinition()
    {
        var ssmActionDefinitionResult = new Humidifier.Budgets.BudgetsActionTypes.SsmActionDefinition();

        return ssmActionDefinitionResult;
    }

} // End Of Class

public static class InnerBudgetsActionSsmActionDefinitionFactoryExtensions
{
}
