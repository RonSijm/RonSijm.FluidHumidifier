// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerPushTemplateAndroidPushNotificationTemplateFactory(Action<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate>
{

    protected override Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate Create()
    {
        var androidPushNotificationTemplateResult = CreateAndroidPushNotificationTemplate();
        factoryAction?.Invoke(androidPushNotificationTemplateResult);

        return androidPushNotificationTemplateResult;
    }

    private Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate CreateAndroidPushNotificationTemplate()
    {
        var androidPushNotificationTemplateResult = new Humidifier.Pinpoint.PushTemplateTypes.AndroidPushNotificationTemplate();

        return androidPushNotificationTemplateResult;
    }

} // End Of Class

public static class InnerPushTemplateAndroidPushNotificationTemplateFactoryExtensions
{
}
