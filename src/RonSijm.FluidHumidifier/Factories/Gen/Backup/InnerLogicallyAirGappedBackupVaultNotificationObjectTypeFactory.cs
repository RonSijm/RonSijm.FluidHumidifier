// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory(Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> factoryAction = null) : SubResourceFactory<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType>
{

    protected override Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType Create()
    {
        var notificationObjectTypeResult = CreateNotificationObjectType();
        factoryAction?.Invoke(notificationObjectTypeResult);

        return notificationObjectTypeResult;
    }

    private Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType CreateNotificationObjectType()
    {
        var notificationObjectTypeResult = new Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType();

        return notificationObjectTypeResult;
    }

} // End Of Class

public static class InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactoryExtensions
{
}
