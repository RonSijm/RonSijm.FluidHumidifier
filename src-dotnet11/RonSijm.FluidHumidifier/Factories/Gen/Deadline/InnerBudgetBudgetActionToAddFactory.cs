// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerBudgetBudgetActionToAddFactory(Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd>
{

    protected override Humidifier.Deadline.BudgetTypes.BudgetActionToAdd Create()
    {
        var budgetActionToAddResult = CreateBudgetActionToAdd();
        factoryAction?.Invoke(budgetActionToAddResult);

        return budgetActionToAddResult;
    }

    private Humidifier.Deadline.BudgetTypes.BudgetActionToAdd CreateBudgetActionToAdd()
    {
        var budgetActionToAddResult = new Humidifier.Deadline.BudgetTypes.BudgetActionToAdd();

        return budgetActionToAddResult;
    }

} // End Of Class

public static class InnerBudgetBudgetActionToAddFactoryExtensions
{
}
