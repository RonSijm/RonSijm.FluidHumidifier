// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetCostTypesFactory(Action<Humidifier.Budgets.BudgetTypes.CostTypes> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.CostTypes>
{

    protected override Humidifier.Budgets.BudgetTypes.CostTypes Create()
    {
        var costTypesResult = CreateCostTypes();
        factoryAction?.Invoke(costTypesResult);

        return costTypesResult;
    }

    private Humidifier.Budgets.BudgetTypes.CostTypes CreateCostTypes()
    {
        var costTypesResult = new Humidifier.Budgets.BudgetTypes.CostTypes();

        return costTypesResult;
    }

} // End Of Class

public static class InnerBudgetCostTypesFactoryExtensions
{
}
