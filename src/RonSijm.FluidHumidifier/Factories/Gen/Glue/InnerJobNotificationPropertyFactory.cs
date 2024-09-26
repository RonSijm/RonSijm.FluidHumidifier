// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerJobNotificationPropertyFactory(Action<Humidifier.Glue.JobTypes.NotificationProperty> factoryAction = null) : SubResourceFactory<Humidifier.Glue.JobTypes.NotificationProperty>
{

    protected override Humidifier.Glue.JobTypes.NotificationProperty Create()
    {
        var notificationPropertyResult = CreateNotificationProperty();
        factoryAction?.Invoke(notificationPropertyResult);

        return notificationPropertyResult;
    }

    private Humidifier.Glue.JobTypes.NotificationProperty CreateNotificationProperty()
    {
        var notificationPropertyResult = new Humidifier.Glue.JobTypes.NotificationProperty();

        return notificationPropertyResult;
    }

} // End Of Class

public static class InnerJobNotificationPropertyFactoryExtensions
{
}
