// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pinpoint;

public class InnerPushTemplateDefaultPushNotificationTemplateFactory(Action<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate> factoryAction = null) : SubResourceFactory<Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate>
{

    protected override Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate Create()
    {
        var defaultPushNotificationTemplateResult = CreateDefaultPushNotificationTemplate();
        factoryAction?.Invoke(defaultPushNotificationTemplateResult);

        return defaultPushNotificationTemplateResult;
    }

    private Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate CreateDefaultPushNotificationTemplate()
    {
        var defaultPushNotificationTemplateResult = new Humidifier.Pinpoint.PushTemplateTypes.DefaultPushNotificationTemplate();

        return defaultPushNotificationTemplateResult;
    }

} // End Of Class

public static class InnerPushTemplateDefaultPushNotificationTemplateFactoryExtensions
{
}
