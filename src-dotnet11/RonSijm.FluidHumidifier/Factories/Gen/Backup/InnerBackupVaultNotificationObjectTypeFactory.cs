// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class InnerBackupVaultNotificationObjectTypeFactory(Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> factoryAction = null) : SubResourceFactory<Humidifier.Backup.BackupVaultTypes.NotificationObjectType>
{

    protected override Humidifier.Backup.BackupVaultTypes.NotificationObjectType Create()
    {
        var notificationObjectTypeResult = CreateNotificationObjectType();
        factoryAction?.Invoke(notificationObjectTypeResult);

        return notificationObjectTypeResult;
    }

    private Humidifier.Backup.BackupVaultTypes.NotificationObjectType CreateNotificationObjectType()
    {
        var notificationObjectTypeResult = new Humidifier.Backup.BackupVaultTypes.NotificationObjectType();

        return notificationObjectTypeResult;
    }

} // End Of Class

public static class InnerBackupVaultNotificationObjectTypeFactoryExtensions
{
}
