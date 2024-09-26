// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rekognition;

public class InnerStreamProcessorNotificationChannelFactory(Action<Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel> factoryAction = null) : SubResourceFactory<Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel>
{

    protected override Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel Create()
    {
        var notificationChannelResult = CreateNotificationChannel();
        factoryAction?.Invoke(notificationChannelResult);

        return notificationChannelResult;
    }

    private Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel CreateNotificationChannel()
    {
        var notificationChannelResult = new Humidifier.Rekognition.StreamProcessorTypes.NotificationChannel();

        return notificationChannelResult;
    }

} // End Of Class

public static class InnerStreamProcessorNotificationChannelFactoryExtensions
{
}
