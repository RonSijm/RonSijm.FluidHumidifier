// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WorkSpacesWeb;

public class SessionLoggerFactory(string resourceName = null, Action<Humidifier.WorkSpacesWeb.SessionLogger> factoryAction = null) : ResourceFactory<Humidifier.WorkSpacesWeb.SessionLogger>(resourceName)
{

    internal InnerSessionLoggerEventFilterFactory EventFilterFactory { get; set; }

    internal InnerSessionLoggerLogConfigurationFactory LogConfigurationFactory { get; set; }

    protected override Humidifier.WorkSpacesWeb.SessionLogger Create()
    {
        var sessionLoggerResult = CreateSessionLogger();
        factoryAction?.Invoke(sessionLoggerResult);

        return sessionLoggerResult;
    }

    private Humidifier.WorkSpacesWeb.SessionLogger CreateSessionLogger()
    {
        var sessionLoggerResult = new Humidifier.WorkSpacesWeb.SessionLogger
        {
            GivenName = InputResourceName,
        };

        return sessionLoggerResult;
    }
    public override void CreateChildren(Humidifier.WorkSpacesWeb.SessionLogger result)
    {
        base.CreateChildren(result);

        result.EventFilter ??= EventFilterFactory?.Build();
        result.LogConfiguration ??= LogConfigurationFactory?.Build();
    }

} // End Of Class

public static class SessionLoggerFactoryExtensions
{
    public static CombinedResult<SessionLoggerFactory, InnerSessionLoggerEventFilterFactory> WithEventFilter(this SessionLoggerFactory parentFactory, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null)
    {
        parentFactory.EventFilterFactory = new InnerSessionLoggerEventFilterFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EventFilterFactory);
    }

    public static CombinedResult<SessionLoggerFactory, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration(this SessionLoggerFactory parentFactory, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null)
    {
        parentFactory.LogConfigurationFactory = new InnerSessionLoggerLogConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LogConfigurationFactory);
    }

    public static CombinedResult<SessionLoggerFactory, T1, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1>(this CombinedResult<SessionLoggerFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1>(this CombinedResult<T1, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<SessionLoggerFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, SessionLoggerFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2>(this CombinedResult<T1, T2, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, T3, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<SessionLoggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, T3, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, SessionLoggerFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, T3, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, SessionLoggerFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionLoggerFactory, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, T3, T4, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<SessionLoggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, T3, T4, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, SessionLoggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, T3, T4, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionLoggerFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionLoggerFactory, T4, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionLoggerFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionLoggerFactory, InnerSessionLoggerEventFilterFactory> WithEventFilter<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.EventFilter> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEventFilter(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<SessionLoggerFactory, T1> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1>(this CombinedResult<T1, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<SessionLoggerFactory, T1, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, SessionLoggerFactory, T2> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2>(this CombinedResult<T1, T2, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, T3, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<SessionLoggerFactory, T1, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, T3, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, SessionLoggerFactory, T2, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, T3, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SessionLoggerFactory, T3> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionLoggerFactory, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionLoggerFactory, T1, T2, T3, T4, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<SessionLoggerFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionLoggerFactory, T2, T3, T4, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SessionLoggerFactory, T2, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionLoggerFactory, T3, T4, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionLoggerFactory, T3, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionLoggerFactory, T4, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionLoggerFactory, T4> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionLoggerFactory, InnerSessionLoggerLogConfigurationFactory> WithLogConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionLoggerFactory> combinedResult, Action<Humidifier.WorkSpacesWeb.SessionLoggerTypes.LogConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLogConfiguration(combinedResult.T5, subFactoryAction).T2);
}
