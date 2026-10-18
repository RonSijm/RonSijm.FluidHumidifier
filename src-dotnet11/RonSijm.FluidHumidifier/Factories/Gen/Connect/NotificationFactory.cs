// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class NotificationFactory(string resourceName = null, Action<Humidifier.Connect.Notification> factoryAction = null) : ResourceFactory<Humidifier.Connect.Notification>(resourceName)
{

    internal InnerNotificationNotificationContentFactory ContentFactory { get; set; }

    protected override Humidifier.Connect.Notification Create()
    {
        var notificationResult = CreateNotification();
        factoryAction?.Invoke(notificationResult);

        return notificationResult;
    }

    private Humidifier.Connect.Notification CreateNotification()
    {
        var notificationResult = new Humidifier.Connect.Notification
        {
            GivenName = InputResourceName,
        };

        return notificationResult;
    }
    public override void CreateChildren(Humidifier.Connect.Notification result)
    {
        base.CreateChildren(result);

        result.Content ??= ContentFactory?.Build();
    }

} // End Of Class

public static class NotificationFactoryExtensions
{
    public static CombinedResult<NotificationFactory, InnerNotificationNotificationContentFactory> WithContent(this NotificationFactory parentFactory, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null)
    {
        parentFactory.ContentFactory = new InnerNotificationNotificationContentFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ContentFactory);
    }

    public static CombinedResult<NotificationFactory, T1, InnerNotificationNotificationContentFactory> WithContent<T1>(this CombinedResult<NotificationFactory, T1> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NotificationFactory, InnerNotificationNotificationContentFactory> WithContent<T1>(this CombinedResult<T1, NotificationFactory> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<NotificationFactory, T1, T2, InnerNotificationNotificationContentFactory> WithContent<T1, T2>(this CombinedResult<NotificationFactory, T1, T2> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NotificationFactory, T2, InnerNotificationNotificationContentFactory> WithContent<T1, T2>(this CombinedResult<T1, NotificationFactory, T2> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NotificationFactory, InnerNotificationNotificationContentFactory> WithContent<T1, T2>(this CombinedResult<T1, T2, NotificationFactory> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<NotificationFactory, T1, T2, T3, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3>(this CombinedResult<NotificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NotificationFactory, T2, T3, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, NotificationFactory, T2, T3> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NotificationFactory, T3, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, NotificationFactory, T3> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NotificationFactory, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3>(this CombinedResult<T1, T2, T3, NotificationFactory> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<NotificationFactory, T1, T2, T3, T4, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<NotificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, NotificationFactory, T2, T3, T4, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, NotificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, NotificationFactory, T3, T4, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, NotificationFactory, T3, T4> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, NotificationFactory, T4, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NotificationFactory, T4> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, NotificationFactory, InnerNotificationNotificationContentFactory> WithContent<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NotificationFactory> combinedResult, Action<Humidifier.Connect.NotificationTypes.NotificationContent> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithContent(combinedResult.T5, subFactoryAction).T2);
}
