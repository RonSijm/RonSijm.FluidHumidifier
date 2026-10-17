// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.UserNotifications;

public class NotificationEventFactory(string resourceName = null, Action<Humidifier.UserNotifications.NotificationEvent> factoryAction = null) : ResourceFactory<Humidifier.UserNotifications.NotificationEvent>(resourceName)
{

    protected override Humidifier.UserNotifications.NotificationEvent Create()
    {
        var notificationEventResult = CreateNotificationEvent();
        factoryAction?.Invoke(notificationEventResult);

        return notificationEventResult;
    }

    private Humidifier.UserNotifications.NotificationEvent CreateNotificationEvent()
    {
        var notificationEventResult = new Humidifier.UserNotifications.NotificationEvent
        {
            GivenName = InputResourceName,
        };

        return notificationEventResult;
    }

} // End Of Class

public static class NotificationEventFactoryExtensions
{
}
