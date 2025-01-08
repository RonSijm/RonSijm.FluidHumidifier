// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Backup;

public class LogicallyAirGappedBackupVaultFactory(string resourceName = null, Action<Humidifier.Backup.LogicallyAirGappedBackupVault> factoryAction = null) : ResourceFactory<Humidifier.Backup.LogicallyAirGappedBackupVault>(resourceName)
{

    internal InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory NotificationsFactory { get; set; }

    protected override Humidifier.Backup.LogicallyAirGappedBackupVault Create()
    {
        var logicallyAirGappedBackupVaultResult = CreateLogicallyAirGappedBackupVault();
        factoryAction?.Invoke(logicallyAirGappedBackupVaultResult);

        return logicallyAirGappedBackupVaultResult;
    }

    private Humidifier.Backup.LogicallyAirGappedBackupVault CreateLogicallyAirGappedBackupVault()
    {
        var logicallyAirGappedBackupVaultResult = new Humidifier.Backup.LogicallyAirGappedBackupVault
        {
            GivenName = InputResourceName,
        };

        return logicallyAirGappedBackupVaultResult;
    }
    public override void CreateChildren(Humidifier.Backup.LogicallyAirGappedBackupVault result)
    {
        base.CreateChildren(result);

        result.Notifications ??= NotificationsFactory?.Build();
    }

} // End Of Class

public static class LogicallyAirGappedBackupVaultFactoryExtensions
{
    public static CombinedResult<LogicallyAirGappedBackupVaultFactory, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications(this LogicallyAirGappedBackupVaultFactory parentFactory, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null)
    {
        parentFactory.NotificationsFactory = new InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationsFactory);
    }

    public static CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1>(this CombinedResult<LogicallyAirGappedBackupVaultFactory, T1> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1>(this CombinedResult<T1, LogicallyAirGappedBackupVaultFactory> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2>(this CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2, T3, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2, T3> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2, T3, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2, T3> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory, T3, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory, T3> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LogicallyAirGappedBackupVaultFactory, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3>(this CombinedResult<T1, T2, T3, LogicallyAirGappedBackupVaultFactory> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2, T3, T4, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<LogicallyAirGappedBackupVaultFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2, T3, T4, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, LogicallyAirGappedBackupVaultFactory, T2, T3, T4> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory, T3, T4, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, LogicallyAirGappedBackupVaultFactory, T3, T4> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, LogicallyAirGappedBackupVaultFactory, T4, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, LogicallyAirGappedBackupVaultFactory, T4> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, LogicallyAirGappedBackupVaultFactory, InnerLogicallyAirGappedBackupVaultNotificationObjectTypeFactory> WithNotifications<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, LogicallyAirGappedBackupVaultFactory> combinedResult, Action<Humidifier.Backup.LogicallyAirGappedBackupVaultTypes.NotificationObjectType> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotifications(combinedResult.T5, subFactoryAction));
}
