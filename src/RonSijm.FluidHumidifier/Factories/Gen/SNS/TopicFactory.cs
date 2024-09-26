// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SNS;

public class TopicFactory(string resourceName = null, Action<Humidifier.SNS.Topic> factoryAction = null) : ResourceFactory<Humidifier.SNS.Topic>(resourceName)
{

    internal List<InnerTopicLoggingConfigFactory> DeliveryStatusLoggingFactories { get; set; } = [];

    internal List<InnerTopicSubscriptionFactory> SubscriptionFactories { get; set; } = [];

    protected override Humidifier.SNS.Topic Create()
    {
        var topicResult = CreateTopic();
        factoryAction?.Invoke(topicResult);

        return topicResult;
    }

    private Humidifier.SNS.Topic CreateTopic()
    {
        var topicResult = new Humidifier.SNS.Topic
        {
            GivenName = InputResourceName,
        };

        return topicResult;
    }
    public override void CreateChildren(Humidifier.SNS.Topic result)
    {
        base.CreateChildren(result);

        result.DeliveryStatusLogging = DeliveryStatusLoggingFactories.Any() ? DeliveryStatusLoggingFactories.Select(x => x.Build()).ToList() : null;
        result.Subscription = SubscriptionFactories.Any() ? SubscriptionFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class TopicFactoryExtensions
{
    public static CombinedResult<TopicFactory, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging(this TopicFactory parentFactory, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null)
    {
        var factory = new InnerTopicLoggingConfigFactory(subFactoryAction);
        parentFactory.DeliveryStatusLoggingFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TopicFactory, InnerTopicSubscriptionFactory> WithSubscription(this TopicFactory parentFactory, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null)
    {
        var factory = new InnerTopicSubscriptionFactory(subFactoryAction);
        parentFactory.SubscriptionFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<TopicFactory, T1, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1>(this CombinedResult<TopicFactory, T1> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1>(this CombinedResult<T1, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2>(this CombinedResult<TopicFactory, T1, T2> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2>(this CombinedResult<T1, TopicFactory, T2> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2>(this CombinedResult<T1, T2, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, T3, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3>(this CombinedResult<TopicFactory, T1, T2, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, T3, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3>(this CombinedResult<T1, TopicFactory, T2, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, T3, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3>(this CombinedResult<T1, T2, TopicFactory, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicFactory, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, T3, T4, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3, T4>(this CombinedResult<TopicFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, T3, T4, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3, T4>(this CombinedResult<T1, TopicFactory, T2, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, T3, T4, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicFactory, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicFactory, T4, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicFactory, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TopicFactory, InnerTopicLoggingConfigFactory> WithDeliveryStatusLogging<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.LoggingConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithDeliveryStatusLogging(combinedResult.T5, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, InnerTopicSubscriptionFactory> WithSubscription<T1>(this CombinedResult<TopicFactory, T1> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, InnerTopicSubscriptionFactory> WithSubscription<T1>(this CombinedResult<T1, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, WithSubscription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, InnerTopicSubscriptionFactory> WithSubscription<T1, T2>(this CombinedResult<TopicFactory, T1, T2> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, InnerTopicSubscriptionFactory> WithSubscription<T1, T2>(this CombinedResult<T1, TopicFactory, T2> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, InnerTopicSubscriptionFactory> WithSubscription<T1, T2>(this CombinedResult<T1, T2, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, T3, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3>(this CombinedResult<TopicFactory, T1, T2, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, T3, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3>(this CombinedResult<T1, TopicFactory, T2, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, T3, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3>(this CombinedResult<T1, T2, TopicFactory, T3> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicFactory, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3>(this CombinedResult<T1, T2, T3, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T4, subFactoryAction));
    public static CombinedResult<TopicFactory, T1, T2, T3, T4, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3, T4>(this CombinedResult<TopicFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, TopicFactory, T2, T3, T4, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3, T4>(this CombinedResult<T1, TopicFactory, T2, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, TopicFactory, T3, T4, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3, T4>(this CombinedResult<T1, T2, TopicFactory, T3, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, TopicFactory, T4, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, TopicFactory, T4> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, TopicFactory, InnerTopicSubscriptionFactory> WithSubscription<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, TopicFactory> combinedResult, Action<Humidifier.SNS.TopicTypes.Subscription> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSubscription(combinedResult.T5, subFactoryAction));
}
