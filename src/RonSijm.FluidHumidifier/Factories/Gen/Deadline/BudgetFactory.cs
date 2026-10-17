// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Deadline;

public class BudgetFactory(string resourceName = null, Action<Humidifier.Deadline.Budget> factoryAction = null) : ResourceFactory<Humidifier.Deadline.Budget>(resourceName)
{

    internal List<InnerBudgetBudgetActionToAddFactory> ActionsFactories { get; set; } = [];

    internal InnerBudgetUsageTrackingResourceFactory UsageTrackingResourceFactory { get; set; }

    internal InnerBudgetBudgetScheduleFactory ScheduleFactory { get; set; }

    protected override Humidifier.Deadline.Budget Create()
    {
        var budgetResult = CreateBudget();
        factoryAction?.Invoke(budgetResult);

        return budgetResult;
    }

    private Humidifier.Deadline.Budget CreateBudget()
    {
        var budgetResult = new Humidifier.Deadline.Budget
        {
            GivenName = InputResourceName,
        };

        return budgetResult;
    }
    public override void CreateChildren(Humidifier.Deadline.Budget result)
    {
        base.CreateChildren(result);

        result.Actions = ActionsFactories.Any() ? ActionsFactories.Select(x => x.Build()).ToList() : null;
        result.UsageTrackingResource ??= UsageTrackingResourceFactory?.Build();
        result.Schedule ??= ScheduleFactory?.Build();
    }

} // End Of Class

public static class BudgetFactoryExtensions
{
    public static CombinedResult<BudgetFactory, InnerBudgetBudgetActionToAddFactory> WithActions(this BudgetFactory parentFactory, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null)
    {
        var factory = new InnerBudgetBudgetActionToAddFactory(subFactoryAction);
        parentFactory.ActionsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BudgetFactory, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource(this BudgetFactory parentFactory, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null)
    {
        parentFactory.UsageTrackingResourceFactory = new InnerBudgetUsageTrackingResourceFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.UsageTrackingResourceFactory);
    }

    public static CombinedResult<BudgetFactory, InnerBudgetBudgetScheduleFactory> WithSchedule(this BudgetFactory parentFactory, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null)
    {
        parentFactory.ScheduleFactory = new InnerBudgetBudgetScheduleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScheduleFactory);
    }

    public static CombinedResult<BudgetFactory, T1, InnerBudgetBudgetActionToAddFactory> WithActions<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, InnerBudgetBudgetActionToAddFactory> WithActions<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetBudgetActionToAddFactory> WithActions<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetActionToAdd> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithActions(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetUsageTrackingResourceFactory> WithUsageTrackingResource<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.UsageTrackingResource> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithUsageTrackingResource(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, InnerBudgetBudgetScheduleFactory> WithSchedule<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, InnerBudgetBudgetScheduleFactory> WithSchedule<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetBudgetScheduleFactory> WithSchedule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Deadline.BudgetTypes.BudgetSchedule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSchedule(combinedResult.T5, subFactoryAction).T2);
}
