// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetExpressionDimensionValuesFactory(Action<Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues>
{

    protected override Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues Create()
    {
        var expressionDimensionValuesResult = CreateExpressionDimensionValues();
        factoryAction?.Invoke(expressionDimensionValuesResult);

        return expressionDimensionValuesResult;
    }

    private Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues CreateExpressionDimensionValues()
    {
        var expressionDimensionValuesResult = new Humidifier.Budgets.BudgetTypes.ExpressionDimensionValues();

        return expressionDimensionValuesResult;
    }

} // End Of Class

public static class InnerBudgetExpressionDimensionValuesFactoryExtensions
{
}
