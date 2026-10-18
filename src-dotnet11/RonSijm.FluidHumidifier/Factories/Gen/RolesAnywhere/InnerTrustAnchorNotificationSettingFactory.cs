// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RolesAnywhere;

public class InnerTrustAnchorNotificationSettingFactory(Action<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting> factoryAction = null) : SubResourceFactory<Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting>
{

    protected override Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting Create()
    {
        var notificationSettingResult = CreateNotificationSetting();
        factoryAction?.Invoke(notificationSettingResult);

        return notificationSettingResult;
    }

    private Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting CreateNotificationSetting()
    {
        var notificationSettingResult = new Humidifier.RolesAnywhere.TrustAnchorTypes.NotificationSetting();

        return notificationSettingResult;
    }

} // End Of Class

public static class InnerTrustAnchorNotificationSettingFactoryExtensions
{
}
