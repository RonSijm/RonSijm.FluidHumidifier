// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.FMS;

public class NotificationChannelFactory(string resourceName = null, Action<Humidifier.FMS.NotificationChannel> factoryAction = null) : ResourceFactory<Humidifier.FMS.NotificationChannel>(resourceName)
{

    protected override Humidifier.FMS.NotificationChannel Create()
    {
        var notificationChannelResult = CreateNotificationChannel();
        factoryAction?.Invoke(notificationChannelResult);

        return notificationChannelResult;
    }

    private Humidifier.FMS.NotificationChannel CreateNotificationChannel()
    {
        var notificationChannelResult = new Humidifier.FMS.NotificationChannel
        {
            GivenName = InputResourceName,
        };

        return notificationChannelResult;
    }

} // End Of Class

public static class NotificationChannelFactoryExtensions
{
}
