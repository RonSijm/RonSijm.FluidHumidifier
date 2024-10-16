// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SecurityLake;

public class InnerSubscriberNotificationNotificationConfigurationFactory(Action<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration>
{

    internal InnerSubscriberNotificationHttpsNotificationConfigurationFactory HttpsNotificationConfigurationFactory { get; set; }

    protected override Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration();

        return notificationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.SecurityLake.SubscriberNotificationTypes.NotificationConfiguration result)
    {
        base.CreateChildren(result);

        result.HttpsNotificationConfiguration ??= HttpsNotificationConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerSubscriberNotificationNotificationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration(this InnerSubscriberNotificationNotificationConfigurationFactory parentFactory, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null)
    {
        parentFactory.HttpsNotificationConfigurationFactory = new InnerSubscriberNotificationHttpsNotificationConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.HttpsNotificationConfigurationFactory);
    }

    public static CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1>(this CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1>(this CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2>(this CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2>(this CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2, T3, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3>(this CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2, T3, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory, T3, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory, T3> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2, T3, T4, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerSubscriberNotificationNotificationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2, T3, T4, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerSubscriberNotificationNotificationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory, T3, T4, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerSubscriberNotificationNotificationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory, T4, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerSubscriberNotificationNotificationConfigurationFactory, T4> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerSubscriberNotificationNotificationConfigurationFactory, InnerSubscriberNotificationHttpsNotificationConfigurationFactory> WithHttpsNotificationConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerSubscriberNotificationNotificationConfigurationFactory> combinedResult, Action<Humidifier.SecurityLake.SubscriberNotificationTypes.HttpsNotificationConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithHttpsNotificationConfiguration(combinedResult.T5, subFactoryAction));
}
