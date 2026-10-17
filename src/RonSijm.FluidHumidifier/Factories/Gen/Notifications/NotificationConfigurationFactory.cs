// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Notifications;

public class NotificationConfigurationFactory(string resourceName = null, Action<Humidifier.Notifications.NotificationConfiguration> factoryAction = null) : ResourceFactory<Humidifier.Notifications.NotificationConfiguration>(resourceName)
{

    protected override Humidifier.Notifications.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.Notifications.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.Notifications.NotificationConfiguration
        {
            GivenName = InputResourceName,
        };

        return notificationConfigurationResult;
    }

} // End Of Class

public static class NotificationConfigurationFactoryExtensions
{
}
