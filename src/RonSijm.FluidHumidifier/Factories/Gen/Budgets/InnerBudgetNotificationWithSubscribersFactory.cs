// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Budgets;

public class InnerBudgetNotificationWithSubscribersFactory(Action<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers> factoryAction = null) : SubResourceFactory<Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers>
{

    internal InnerBudgetNotificationFactory NotificationFactory { get; set; }

    protected override Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers Create()
    {
        var notificationWithSubscribersResult = CreateNotificationWithSubscribers();
        factoryAction?.Invoke(notificationWithSubscribersResult);

        return notificationWithSubscribersResult;
    }

    private Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers CreateNotificationWithSubscribers()
    {
        var notificationWithSubscribersResult = new Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers();

        return notificationWithSubscribersResult;
    }
    public override void CreateChildren(Humidifier.Budgets.BudgetTypes.NotificationWithSubscribers result)
    {
        base.CreateChildren(result);

        result.Notification ??= NotificationFactory?.Build();
    }

} // End Of Class

public static class InnerBudgetNotificationWithSubscribersFactoryExtensions
{
    public static CombinedResult<InnerBudgetNotificationWithSubscribersFactory, InnerBudgetNotificationFactory> WithNotification(this InnerBudgetNotificationWithSubscribersFactory parentFactory, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null)
    {
        parentFactory.NotificationFactory = new InnerBudgetNotificationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationFactory);
    }

    public static CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, InnerBudgetNotificationFactory> WithNotification<T1>(this CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, InnerBudgetNotificationFactory> WithNotification<T1>(this CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2, InnerBudgetNotificationFactory> WithNotification<T1, T2>(this CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2, InnerBudgetNotificationFactory> WithNotification<T1, T2>(this CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory, InnerBudgetNotificationFactory> WithNotification<T1, T2>(this CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2, T3, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3>(this CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2, T3, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3>(this CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory, T3, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3>(this CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory, T3> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBudgetNotificationWithSubscribersFactory, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBudgetNotificationWithSubscribersFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2, T3, T4, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3, T4>(this CombinedResult<InnerBudgetNotificationWithSubscribersFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2, T3, T4, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3, T4>(this CombinedResult<T1, InnerBudgetNotificationWithSubscribersFactory, T2, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory, T3, T4, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBudgetNotificationWithSubscribersFactory, T3, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBudgetNotificationWithSubscribersFactory, T4, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBudgetNotificationWithSubscribersFactory, T4> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBudgetNotificationWithSubscribersFactory, InnerBudgetNotificationFactory> WithNotification<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBudgetNotificationWithSubscribersFactory> combinedResult, Action<Humidifier.Budgets.BudgetTypes.Notification> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotification(combinedResult.T5, subFactoryAction));
}
