// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerBudgetFixedBudgetScheduleFactory(Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule>
{

    protected override Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule Create()
    {
        var fixedBudgetScheduleResult = CreateFixedBudgetSchedule();
        factoryAction?.Invoke(fixedBudgetScheduleResult);

        return fixedBudgetScheduleResult;
    }

    private Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule CreateFixedBudgetSchedule()
    {
        var fixedBudgetScheduleResult = new Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule();

        return fixedBudgetScheduleResult;
    }

} // End Of Class

public static class InnerBudgetFixedBudgetScheduleFactoryExtensions
{
}
