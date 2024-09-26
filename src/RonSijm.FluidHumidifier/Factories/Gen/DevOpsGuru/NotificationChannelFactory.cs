// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsGuru;

public class NotificationChannelFactory(string resourceName = null, Action<Humidifier.DevOpsGuru.NotificationChannel> factoryAction = null) : ResourceFactory<Humidifier.DevOpsGuru.NotificationChannel>(resourceName)
{

    internal InnerNotificationChannelNotificationChannelConfigFactory ConfigFactory { get; set; }

    protected override Humidifier.DevOpsGuru.NotificationChannel Create()
    {
        var notificationChannelResult = CreateNotificationChannel();
        factoryAction?.Invoke(notificationChannelResult);

        return notificationChannelResult;
    }

    private Humidifier.DevOpsGuru.NotificationChannel CreateNotificationChannel()
    {
        var notificationChannelResult = new Humidifier.DevOpsGuru.NotificationChannel
        {
            GivenName = InputResourceName,
        };

        return notificationChannelResult;
    }
    public override void CreateChildren(Humidifier.DevOpsGuru.NotificationChannel result)
    {
        base.CreateChildren(result);

        result.Config ??= ConfigFactory?.Build();
    }

} // End Of Class

public static class NotificationChannelFactoryExtensions
{
    public static CombinedResult<NotificationChannelFactory, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig(this NotificationChannelFactory parentFactory, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null)
    {
        parentFactory.ConfigFactory = new InnerNotificationChannelNotificationChannelConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigFactory);
    }

    public static CombinedResult<NotificationChannelFactory, T1, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1>(this CombinedResult<NotificationChannelFactory, T1> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationChannelFactory, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1>(this CombinedResult<T1, NotificationChannelFactory> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<NotificationChannelFactory, T1, T2, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2>(this CombinedResult<NotificationChannelFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationChannelFactory, T2, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, NotificationChannelFactory, T2> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationChannelFactory, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2>(this CombinedResult<T1, T2, NotificationChannelFactory> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<NotificationChannelFactory, T1, T2, T3, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<NotificationChannelFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationChannelFactory, T2, T3, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, NotificationChannelFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationChannelFactory, T3, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, NotificationChannelFactory, T3> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotificationChannelFactory, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, NotificationChannelFactory> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<NotificationChannelFactory, T1, T2, T3, T4, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<NotificationChannelFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, NotificationChannelFactory, T2, T3, T4, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, NotificationChannelFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, NotificationChannelFactory, T3, T4, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, NotificationChannelFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, NotificationChannelFactory, T4, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, NotificationChannelFactory, T4> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, NotificationChannelFactory, InnerNotificationChannelNotificationChannelConfigFactory> WithConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, NotificationChannelFactory> combinedResult, Action<Humidifier.DevOpsGuru.NotificationChannelTypes.NotificationChannelConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfig(combinedResult.T5, subFactoryAction));
}
