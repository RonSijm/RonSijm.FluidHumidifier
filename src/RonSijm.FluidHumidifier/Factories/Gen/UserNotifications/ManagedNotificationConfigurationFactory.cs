// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.UserNotifications;

public class ManagedNotificationConfigurationFactory(string resourceName = null, Action<Humidifier.UserNotifications.ManagedNotificationConfiguration> factoryAction = null) : ResourceFactory<Humidifier.UserNotifications.ManagedNotificationConfiguration>(resourceName)
{

    protected override Humidifier.UserNotifications.ManagedNotificationConfiguration Create()
    {
        var managedNotificationConfigurationResult = CreateManagedNotificationConfiguration();
        factoryAction?.Invoke(managedNotificationConfigurationResult);

        return managedNotificationConfigurationResult;
    }

    private Humidifier.UserNotifications.ManagedNotificationConfiguration CreateManagedNotificationConfiguration()
    {
        var managedNotificationConfigurationResult = new Humidifier.UserNotifications.ManagedNotificationConfiguration
        {
            GivenName = InputResourceName,
        };

        return managedNotificationConfigurationResult;
    }

} // End Of Class

public static class ManagedNotificationConfigurationFactoryExtensions
{
}
