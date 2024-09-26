// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.S3;

public class InnerBucketNotificationConfigurationFactory(Action<Humidifier.S3.BucketTypes.NotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.S3.BucketTypes.NotificationConfiguration>
{

    internal InnerBucketEventBridgeConfigurationFactory EventBridgeConfigurationFactory { get; set; }

    protected override Humidifier.S3.BucketTypes.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.S3.BucketTypes.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.S3.BucketTypes.NotificationConfiguration();

        return notificationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.S3.BucketTypes.NotificationConfiguration result)
    {
        base.CreateChildren(result);

        result.EventBridgeConfiguration ??= EventBridgeConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerBucketNotificationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerBucketNotificationConfigurationFactory, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration(this InnerBucketNotificationConfigurationFactory parentFactory, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null)
    {
        parentFactory.EventBridgeConfigurationFactory = new InnerBucketEventBridgeConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventBridgeConfigurationFactory);
    }

    public static CombinedResult<InnerBucketNotificationConfigurationFactory, T1, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1>(this CombinedResult<InnerBucketNotificationConfigurationFactory, T1> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketNotificationConfigurationFactory, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1>(this CombinedResult<T1, InnerBucketNotificationConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2>(this CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2>(this CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2, T3, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3>(this CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2, T3, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory, T3, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory, T3> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketNotificationConfigurationFactory, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerBucketNotificationConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2, T3, T4, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerBucketNotificationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2, T3, T4, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerBucketNotificationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory, T3, T4, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerBucketNotificationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerBucketNotificationConfigurationFactory, T4, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerBucketNotificationConfigurationFactory, T4> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerBucketNotificationConfigurationFactory, InnerBucketEventBridgeConfigurationFactory> WithEventBridgeConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerBucketNotificationConfigurationFactory> combinedResult, Action<Humidifier.S3.BucketTypes.EventBridgeConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventBridgeConfiguration(combinedResult.T5, subFactoryAction));
}
