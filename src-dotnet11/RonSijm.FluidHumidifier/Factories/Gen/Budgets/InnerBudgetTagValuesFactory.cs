// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetTagValuesFactory(Action<Humidifier.Budgets.BudgetTypes.TagValues> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.TagValues>
{

    protected override Humidifier.Budgets.BudgetTypes.TagValues Create()
    {
        var tagValuesResult = CreateTagValues();
        factoryAction?.Invoke(tagValuesResult);

        return tagValuesResult;
    }

    private Humidifier.Budgets.BudgetTypes.TagValues CreateTagValues()
    {
        var tagValuesResult = new Humidifier.Budgets.BudgetTypes.TagValues();

        return tagValuesResult;
    }

} // End Of Class

public static class InnerBudgetTagValuesFactoryExtensions
{
}
