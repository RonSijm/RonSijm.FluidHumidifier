// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Athena;

public class SessionFactory(string resourceName = null, Action<Humidifier.Athena.Session> factoryAction = null) : ResourceFactory<Humidifier.Athena.Session>(resourceName)
{

    internal InnerSessionEngineConfigurationFactory EngineConfigurationFactory { get; set; }

    protected override Humidifier.Athena.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.Athena.Session CreateSession()
    {
        var sessionResult = new Humidifier.Athena.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }
    public override void CreateChildren(Humidifier.Athena.Session result)
    {
        base.CreateChildren(result);

        result.EngineConfiguration ??= EngineConfigurationFactory?.Build();
    }

} // End Of Class

public static class SessionFactoryExtensions
{
    public static CombinedResult<SessionFactory, InnerSessionEngineConfigurationFactory> WithEngineConfiguration(this SessionFactory parentFactory, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null)
    {
        parentFactory.EngineConfigurationFactory = new InnerSessionEngineConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.EngineConfigurationFactory);
    }

    public static CombinedResult<SessionFactory, T1, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionEngineConfigurationFactory> WithEngineConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.Athena.SessionTypes.EngineConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithEngineConfiguration(combinedResult.T5, subFactoryAction).T2);
}
