// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Glue;

public class InnerTriggerNotificationPropertyFactory(Action<Humidifier.Glue.TriggerTypes.NotificationProperty> factoryAction = null) : SubResourceFactory<Humidifier.Glue.TriggerTypes.NotificationProperty>
{

    protected override Humidifier.Glue.TriggerTypes.NotificationProperty Create()
    {
        var notificationPropertyResult = CreateNotificationProperty();
        factoryAction?.Invoke(notificationPropertyResult);

        return notificationPropertyResult;
    }

    private Humidifier.Glue.TriggerTypes.NotificationProperty CreateNotificationProperty()
    {
        var notificationPropertyResult = new Humidifier.Glue.TriggerTypes.NotificationProperty();

        return notificationPropertyResult;
    }

} // End Of Class

public static class InnerTriggerNotificationPropertyFactoryExtensions
{
}
