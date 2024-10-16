// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SSM;

public class InnerMaintenanceWindowTaskNotificationConfigFactory(Action<Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig> factoryAction = null) : SubResourceFactory<Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig>
{

    protected override Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig Create()
    {
        var notificationConfigResult = CreateNotificationConfig();
        factoryAction?.Invoke(notificationConfigResult);

        return notificationConfigResult;
    }

    private Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig CreateNotificationConfig()
    {
        var notificationConfigResult = new Humidifier.SSM.MaintenanceWindowTaskTypes.NotificationConfig();

        return notificationConfigResult;
    }

} // End Of Class

public static class InnerMaintenanceWindowTaskNotificationConfigFactoryExtensions
{
}
