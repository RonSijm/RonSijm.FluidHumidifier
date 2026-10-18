// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetTimePeriodFactory(Action<Humidifier.Budgets.BudgetTypes.TimePeriod> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.TimePeriod>
{

    protected override Humidifier.Budgets.BudgetTypes.TimePeriod Create()
    {
        var timePeriodResult = CreateTimePeriod();
        factoryAction?.Invoke(timePeriodResult);

        return timePeriodResult;
    }

    private Humidifier.Budgets.BudgetTypes.TimePeriod CreateTimePeriod()
    {
        var timePeriodResult = new Humidifier.Budgets.BudgetTypes.TimePeriod();

        return timePeriodResult;
    }

} // End Of Class

public static class InnerBudgetTimePeriodFactoryExtensions
{
}
