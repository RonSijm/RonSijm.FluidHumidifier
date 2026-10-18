// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetCostCategoryValuesFactory(Action<Humidifier.Budgets.BudgetTypes.CostCategoryValues> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.CostCategoryValues>
{

    protected override Humidifier.Budgets.BudgetTypes.CostCategoryValues Create()
    {
        var costCategoryValuesResult = CreateCostCategoryValues();
        factoryAction?.Invoke(costCategoryValuesResult);

        return costCategoryValuesResult;
    }

    private Humidifier.Budgets.BudgetTypes.CostCategoryValues CreateCostCategoryValues()
    {
        var costCategoryValuesResult = new Humidifier.Budgets.BudgetTypes.CostCategoryValues();

        return costCategoryValuesResult;
    }

} // End Of Class

public static class InnerBudgetCostCategoryValuesFactoryExtensions
{
}
