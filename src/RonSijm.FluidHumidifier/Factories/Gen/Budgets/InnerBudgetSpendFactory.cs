// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetSpendFactory(Action<Humidifier.Budgets.BudgetTypes.Spend> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.Spend>
{

    protected override Humidifier.Budgets.BudgetTypes.Spend Create()
    {
        var spendResult = CreateSpend();
        factoryAction?.Invoke(spendResult);

        return spendResult;
    }

    private Humidifier.Budgets.BudgetTypes.Spend CreateSpend()
    {
        var spendResult = new Humidifier.Budgets.BudgetTypes.Spend();

        return spendResult;
    }

} // End Of Class

public static class InnerBudgetSpendFactoryExtensions
{
}
