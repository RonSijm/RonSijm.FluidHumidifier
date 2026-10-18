// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMR;

public class SessionFactory(string resourceName = null, Action<Humidifier.EMR.Session> factoryAction = null) : ResourceFactory<Humidifier.EMR.Session>(resourceName)
{

    internal List<InnerSessionConfigurationFactory> EngineConfigurationsFactories { get; set; } = [];

    internal InnerSessionSessionMonitoringConfigurationFactory MonitoringConfigurationFactory { get; set; }

    protected override Humidifier.EMR.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.EMR.Session CreateSession()
    {
        var sessionResult = new Humidifier.EMR.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }
    public override void CreateChildren(Humidifier.EMR.Session result)
    {
        base.CreateChildren(result);

        result.EngineConfigurations = EngineConfigurationsFactories.Any() ? EngineConfigurationsFactories.Select(x => x.Build()).ToList() : null;
        result.MonitoringConfiguration ??= MonitoringConfigurationFactory?.Build();
    }

} // End Of Class

public static class SessionFactoryExtensions
{
    public static CombinedResult<SessionFactory, InnerSessionConfigurationFactory> WithEngineConfigurations(this SessionFactory parentFactory, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null)
    {
        var factory = new InnerSessionConfigurationFactory(subFactoryAction);
        parentFactory.EngineConfigurationsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<SessionFactory, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration(this SessionFactory parentFactory, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null)
    {
        parentFactory.MonitoringConfigurationFactory = new InnerSessionSessionMonitoringConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MonitoringConfigurationFactory);
    }

    public static CombinedResult<SessionFactory, T1, InnerSessionConfigurationFactory> WithEngineConfigurations<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionConfigurationFactory> WithEngineConfigurations<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionConfigurationFactory> WithEngineConfigurations<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.Configuration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfigurations(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionSessionMonitoringConfigurationFactory> WithMonitoringConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.EMR.SessionTypes.SessionMonitoringConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMonitoringConfiguration(combinedResult.T5, subFactoryAction).T2);
}
