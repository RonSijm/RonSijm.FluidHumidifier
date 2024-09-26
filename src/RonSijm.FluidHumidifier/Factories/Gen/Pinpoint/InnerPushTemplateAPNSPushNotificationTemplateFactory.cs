// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerPushTemplateAPNSPushNotificationTemplateFactory(Action<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate>
{

    protected override Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate Create()
    {
        var aPNSPushNotificationTemplateResult = CreateAPNSPushNotificationTemplate();
        factoryAction?.Invoke(aPNSPushNotificationTemplateResult);

        return aPNSPushNotificationTemplateResult;
    }

    private Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate CreateAPNSPushNotificationTemplate()
    {
        var aPNSPushNotificationTemplateResult = new Humidifier.Pinpoint.PushTemplateTypes.APNSPushNotificationTemplate();

        return aPNSPushNotificationTemplateResult;
    }

} // End Of Class

public static class InnerPushTemplateAPNSPushNotificationTemplateFactoryExtensions
{
}
