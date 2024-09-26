// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Timestream;

public class InnerScheduledQueryNotificationConfigurationFactory(Action<Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration>
{

    internal InnerScheduledQuerySnsConfigurationFactory SnsConfigurationFactory { get; set; }

    protected override Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration Create()
    {
        var notificationConfigurationResult = CreateNotificationConfiguration();
        factoryAction?.Invoke(notificationConfigurationResult);

        return notificationConfigurationResult;
    }

    private Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration CreateNotificationConfiguration()
    {
        var notificationConfigurationResult = new Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration();

        return notificationConfigurationResult;
    }
    public override void CreateChildren(Humidifier.Timestream.ScheduledQueryTypes.NotificationConfiguration result)
    {
        base.CreateChildren(result);

        result.SnsConfiguration ??= SnsConfigurationFactory?.Build();
    }

} // End Of Class

public static class InnerScheduledQueryNotificationConfigurationFactoryExtensions
{
    public static CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration(this InnerScheduledQueryNotificationConfigurationFactory parentFactory, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null)
    {
        parentFactory.SnsConfigurationFactory = new InnerScheduledQuerySnsConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.SnsConfigurationFactory);
    }

    public static CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1>(this CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1>(this CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2>(this CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2>(this CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2>(this CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2, T3, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3>(this CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2, T3, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3>(this CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory, T3, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory, T3> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryNotificationConfigurationFactory, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerScheduledQueryNotificationConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2, T3, T4, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3, T4>(this CombinedResult<InnerScheduledQueryNotificationConfigurationFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2, T3, T4, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, InnerScheduledQueryNotificationConfigurationFactory, T2, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory, T3, T4, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerScheduledQueryNotificationConfigurationFactory, T3, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerScheduledQueryNotificationConfigurationFactory, T4, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerScheduledQueryNotificationConfigurationFactory, T4> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerScheduledQueryNotificationConfigurationFactory, InnerScheduledQuerySnsConfigurationFactory> WithSnsConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerScheduledQueryNotificationConfigurationFactory> combinedResult, Action<Humidifier.Timestream.ScheduledQueryTypes.SnsConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithSnsConfiguration(combinedResult.T5, subFactoryAction));
}
