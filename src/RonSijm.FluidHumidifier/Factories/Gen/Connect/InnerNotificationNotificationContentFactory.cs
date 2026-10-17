// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Connect;

public class InnerNotificationNotificationContentFactory(Action<Humidifier.Connect.NotificationTypes.NotificationContent> factoryAction = null) : SubResourceFactory<Humidifier.Connect.NotificationTypes.NotificationContent>
{

    protected override Humidifier.Connect.NotificationTypes.NotificationContent Create()
    {
        var notificationContentResult = CreateNotificationContent();
        factoryAction?.Invoke(notificationContentResult);

        return notificationContentResult;
    }

    private Humidifier.Connect.NotificationTypes.NotificationContent CreateNotificationContent()
    {
        var notificationContentResult = new Humidifier.Connect.NotificationTypes.NotificationContent();

        return notificationContentResult;
    }

} // End Of Class

public static class InnerNotificationNotificationContentFactoryExtensions
{
}
