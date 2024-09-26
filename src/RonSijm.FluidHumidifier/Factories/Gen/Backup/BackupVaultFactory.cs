// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class BackupVaultFactory(string resourceName = null, Action<Humidifier.Backup.BackupVault> factoryAction = null) : ResourceFactory<Humidifier.Backup.BackupVault>(resourceName)
{

    internal InnerBackupVaultLockConfigurationTypeFactory LockConfigurationFactory { get; set; }

    internal InnerBackupVaultNotificationObjectTypeFactory NotificationsFactory { get; set; }

    protected override Humidifier.Backup.BackupVault Create()
    {
        var backupVaultResult = CreateBackupVault();
        factoryAction?.Invoke(backupVaultResult);

        return backupVaultResult;
    }

    private Humidifier.Backup.BackupVault CreateBackupVault()
    {
        var backupVaultResult = new Humidifier.Backup.BackupVault
        {
            GivenName = InputResourceName,
        };

        return backupVaultResult;
    }
    public override void CreateChildren(Humidifier.Backup.BackupVault result)
    {
        base.CreateChildren(result);

        result.LockConfiguration ??= LockConfigurationFactory?.Build();
        result.Notifications ??= NotificationsFactory?.Build();
    }

} // End Of Class

public static class BackupVaultFactoryExtensions
{
    public static CombinedResult<BackupVaultFactory, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration(this BackupVaultFactory parentFactory, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null)
    {
        parentFactory.LockConfigurationFactory = new InnerBackupVaultLockConfigurationTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LockConfigurationFactory);
    }

    public static CombinedResult<BackupVaultFactory, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications(this BackupVaultFactory parentFactory, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null)
    {
        parentFactory.NotificationsFactory = new InnerBackupVaultNotificationObjectTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationsFactory);
    }

    public static CombinedResult<BackupVaultFactory, T1, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1>(this CombinedResult<BackupVaultFactory, T1> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1>(this CombinedResult<T1, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2>(this CombinedResult<BackupVaultFactory, T1, T2> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2>(this CombinedResult<T1, BackupVaultFactory, T2> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2>(this CombinedResult<T1, T2, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, T3, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<BackupVaultFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, T3, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, BackupVaultFactory, T2, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, T3, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, BackupVaultFactory, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupVaultFactory, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, T3, T4, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<BackupVaultFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, T3, T4, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, BackupVaultFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, T3, T4, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, BackupVaultFactory, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupVaultFactory, T4, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BackupVaultFactory, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BackupVaultFactory, InnerBackupVaultLockConfigurationTypeFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.LockConfigurationType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1>(this CombinedResult<BackupVaultFactory, T1> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1>(this CombinedResult<T1, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<BackupVaultFactory, T1, T2> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<T1, BackupVaultFactory, T2> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<T1, T2, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, T3, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<BackupVaultFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, T3, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, BackupVaultFactory, T2, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, T3, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, T2, BackupVaultFactory, T3> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupVaultFactory, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<BackupVaultFactory, T1, T2, T3, T4, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<BackupVaultFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, BackupVaultFactory, T2, T3, T4, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, BackupVaultFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, BackupVaultFactory, T3, T4, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, BackupVaultFactory, T3, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, BackupVaultFactory, T4, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, BackupVaultFactory, T4> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, BackupVaultFactory, InnerBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, BackupVaultFactory> combinedResult, Action<Humidifier.Backup.BackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T5, subFactoryAction));
}
