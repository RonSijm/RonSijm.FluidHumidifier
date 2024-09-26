// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class BudgetFactory(string resourceName = null, Action<Humidifier.Budgets.Budget> factoryAction = null) : ResourceFactory<Humidifier.Budgets.Budget>(resourceName)
{

    internal List<InnerBudgetNotificationWithSubscribersFactory> NotificationsWithSubscribersFactories { get; set; } = [];

    internal List<InnerBudgetResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal InnerBudgetBudgetDataFactory Budget_Factory { get; set; }

    protected override Humidifier.Budgets.Budget Create()
    {
        var budgetResult = CreateBudget();
        factoryAction?.Invoke(budgetResult);

        return budgetResult;
    }

    private Humidifier.Budgets.Budget CreateBudget()
    {
        var budgetResult = new Humidifier.Budgets.Budget
        {
            GivenName = InputResourceName,
        };

        return budgetResult;
    }
    public override void CreateChildren(Humidifier.Budgets.Budget result)
    {
        base.CreateChildren(result);

        result.NotificationsWithSubscribers = NotificationsWithSubscribersFactories.Any() ? NotificationsWithSubscribersFactories.Select(x => x.Build()).ToList() : null;
        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.Budget_ ??= Budget_Factory?.Build();
    }

} // End Of Class

public static class BudgetFactoryExtensions
{
    public static CombinedResult<BudgetFactory, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers(this BudgetFactory parentFactory, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null)
    {
        var factory = new InnerBudgetNotificationWithSubscribersFactory(subFactoryAction);
        parentFactory.NotificationsWithSubscribersFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BudgetFactory, InnerBudgetResourceTagFactory> WithResourceTags(this BudgetFactory parentFactory, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerBudgetResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<BudgetFactory, InnerBudgetBudgetDataFactory> WithBudget_(this BudgetFactory parentFactory, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null)
    {
        parentFactory.Budget_Factory = new InnerBudgetBudgetDataFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.Budget_Factory);
    }

    public static CombinedResult<BudgetFactory, T1, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetNotificationWithSubscribersFactory> WithNotificationsWithSubscribers<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationsWithSubscribers(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, InnerBudgetResourceTagFactory> WithResourceTags<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, InnerBudgetResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, InnerBudgetBudgetDataFactory> WithBudget_<T1>(this CombinedResult<BudgetFactory, T1> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, WithBudget_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, InnerBudgetBudgetDataFactory> WithBudget_<T1>(this CombinedResult<T1, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, WithBudget_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2>(this CombinedResult<BudgetFactory, T1, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2>(this CombinedResult<T1, BudgetFactory, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2>(this CombinedResult<T1, T2, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3>(this CombinedResult<BudgetFactory, T1, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3>(this CombinedResult<T1, BudgetFactory, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3>(this CombinedResult<T1, T2, BudgetFactory, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3>(this CombinedResult<T1, T2, T3, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BudgetFactory, T1, T2, T3, T4, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3, T4>(this CombinedResult<BudgetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BudgetFactory, T2, T3, T4, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3, T4>(this CombinedResult<T1, BudgetFactory, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BudgetFactory, T3, T4, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3, T4>(this CombinedResult<T1, T2, BudgetFactory, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BudgetFactory, T4, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BudgetFactory, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BudgetFactory, InnerBudgetBudgetDataFactory> WithBudget_<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BudgetFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.BudgetData> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithBudget_(combinedResult.T5, subFactoryAction));
}
