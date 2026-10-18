// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class InnerBudgetBudgetScheduleFactory(Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> factoryAction = null) : SubResourceFactory<Humidifier.Deadline.BudgetTypes.BudgetSchedule>
{

    internal InnerBudgetFixedBudgetScheduleFactory FixedFactory { get; set; }

    protected override Humidifier.Deadline.BudgetTypes.BudgetSchedule Create()
    {
        var budgetScheduleResult = CreateBudgetSchedule();
        factoryAction?.Invoke(budgetScheduleResult);

        return budgetScheduleResult;
    }

    private Humidifier.Deadline.BudgetTypes.BudgetSchedule CreateBudgetSchedule()
    {
        var budgetScheduleResult = new Humidifier.Deadline.BudgetTypes.BudgetSchedule();

        return budgetScheduleResult;
    }
    public override void CreateChildren(Humidifier.Deadline.BudgetTypes.BudgetSchedule result)
    {
        base.CreateChildren(result);

        result.Fixed ??= FixedFactory?.Build();
    }

} // End Of Class

public static class InnerBudgetBudgetScheduleFactoryExtensions
{
    public static CombinedResult<InnerBudgetBudgetScheduleFactory, InnerBudgetFixedBudgetScheduleFactory> WithFixed(this InnerBudgetBudgetScheduleFactory parentFactory, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null)
    {
        parentFactory.FixedFactory = new InnerBudgetFixedBudgetScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FixedFactory);
    }

    public static CombinedResult<InnerBudgetBudgetScheduleFactory, T1, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1>(this CombinedResult<InnerBudgetBudgetScheduleFactory, T1> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixed(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBudgetBudgetScheduleFactory, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1>(this CombinedResult<T1, InnerBudgetBudgetScheduleFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithFixed(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2>(this CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2>(this CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2>(this CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2, T3, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3>(this CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2, T3, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3>(this CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory, T3, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3>(this CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBudgetBudgetScheduleFactory, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBudgetBudgetScheduleFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2, T3, T4, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3, T4>(this CombinedResult<InnerBudgetBudgetScheduleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2, T3, T4, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3, T4>(this CombinedResult<T1, InnerBudgetBudgetScheduleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory, T3, T4, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBudgetBudgetScheduleFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerBudgetBudgetScheduleFactory, T4, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBudgetBudgetScheduleFactory, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerBudgetBudgetScheduleFactory, InnerBudgetFixedBudgetScheduleFactory> WithFixed<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBudgetBudgetScheduleFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.FixedBudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFixed(combinedResult.T5, subFactoryAction).T2);
}
