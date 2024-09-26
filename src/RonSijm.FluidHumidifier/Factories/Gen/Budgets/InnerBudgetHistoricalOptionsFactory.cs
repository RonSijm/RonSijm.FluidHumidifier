// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetHistoricalOptionsFactory(Action<Humidifier.Budgets.BudgetTypes.HistoricalOptions> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.HistoricalOptions>
{

    protected override Humidifier.Budgets.BudgetTypes.HistoricalOptions Create()
    {
        var historicalOptionsResult = CreateHistoricalOptions();
        factoryAction?.Invoke(historicalOptionsResult);

        return historicalOptionsResult;
    }

    private Humidifier.Budgets.BudgetTypes.HistoricalOptions CreateHistoricalOptions()
    {
        var historicalOptionsResult = new Humidifier.Budgets.BudgetTypes.HistoricalOptions();

        return historicalOptionsResult;
    }

} // End Of Class

public static class InnerBudgetHistoricalOptionsFactoryExtensions
{
}
