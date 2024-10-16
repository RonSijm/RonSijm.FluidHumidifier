// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class SubscriberNotificationFactory(string resourceName = null, Action<Humidifier.SecurityLake.SubscriberNotification> factoryAction = null) : ResourceFactory<Humidifier.SecurityLake.SubscriberNotification>(resourceName)
{

    internal InnerSubscriberNotificationNotificationConfigurationFactory NotificationConfigurationFactory { get; set; }

    protected override Humidifier.SecurityLake.SubscriberNotification Create()
    {
        var subscriberNotificationResult = CreateSubscriberNotification();
        factoryAction?.Invoke(subscriberNotificationResult);

        return subscriberNotificationResult;
    }

    private Humidifier.SecurityLake.SubscriberNotification CreateSubscriberNotification()
    {
        var subscriberNotificationResult = new Humidifier.SecurityLake.SubscriberNotification
        {
            GivenName = InputResourceName,
        };

        return subscriberNotificationResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.SubscriberNotification result)
    {
        base.CreateChildren(result);

        result.NotificationConfiguration ??= NotificationConfigurationFactory?.Build();
    }

} // End Of Class

public static class SubscriberNotificationFactoryExtensions
{
    public static CombinedResult<SubscriberNotificationFactory, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration(this SubscriberNotificationFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null)
    {
        parentFactory.NotificationConfigurationFactory = new InnerSubscriberNotificationNotificationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.NotificationConfigurationFactory);
    }

    public static CombinedResult<SubscriberNotificationFactory, T1, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1>(this CombinedResult<SubscriberNotificationFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberNotificationFactory, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1>(this CombinedResult<T1, SubscriberNotificationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SubscriberNotificationFactory, T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<SubscriberNotificationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberNotificationFactory, T2, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<T1, SubscriberNotificationFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberNotificationFactory, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2>(this CombinedResult<T1, T2, SubscriberNotificationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SubscriberNotificationFactory, T1, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<SubscriberNotificationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberNotificationFactory, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, SubscriberNotificationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberNotificationFactory, T3, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SubscriberNotificationFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberNotificationFactory, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SubscriberNotificationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SubscriberNotificationFactory, T1, T2, T3, T4, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<SubscriberNotificationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SubscriberNotificationFactory, T2, T3, T4, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SubscriberNotificationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SubscriberNotificationFactory, T3, T4, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SubscriberNotificationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SubscriberNotificationFactory, T4, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SubscriberNotificationFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SubscriberNotificationFactory, InnerSubscriberNotificationNotificationConfigurationFactory> WithNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SubscriberNotificationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithNotificationConfiguration(combinedResult.T5, subFactoryAction));
}
