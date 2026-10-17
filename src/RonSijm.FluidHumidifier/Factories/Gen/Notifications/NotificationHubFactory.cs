// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class NotificationHubFactory(string resourceName = null, Action<Humidifier.Notifications.NotificationHub> factoryAction = null) : ResourceFactory<Humidifier.Notifications.NotificationHub>(resourceName)
{

    protected override Humidifier.Notifications.NotificationHub Create()
    {
        var notificationHubResult = CreateNotificationHub();
        factoryAction?.Invoke(notificationHubResult);

        return notificationHubResult;
    }

    private Humidifier.Notifications.NotificationHub CreateNotificationHub()
    {
        var notificationHubResult = new Humidifier.Notifications.NotificationHub
        {
            GivenName = InputResourceName,
        };

        return notificationHubResult;
    }

} // End Of Class

public static class NotificationHubFactoryExtensions
{
}
