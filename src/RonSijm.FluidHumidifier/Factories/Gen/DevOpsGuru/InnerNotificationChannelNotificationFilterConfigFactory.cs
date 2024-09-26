// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class InnerNotificationChannelNotificationFilterConfigFactory(Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig>
{

    protected override Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig Create()
    {
        var notificationFilterConfigResult = CreateNotificationFilterConfig();
        factoryAction?.Invoke(notificationFilterConfigResult);

        return notificationFilterConfigResult;
    }

    private Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig CreateNotificationFilterConfig()
    {
        var notificationFilterConfigResult = new Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationFilterConfig();

        return notificationFilterConfigResult;
    }

} // End Of Class

public static class InnerNotificationChannelNotificationFilterConfigFactoryExtensions
{
}
