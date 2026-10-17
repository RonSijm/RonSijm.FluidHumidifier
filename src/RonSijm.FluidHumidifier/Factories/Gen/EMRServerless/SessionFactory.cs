// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.EMRServerless;

public class SessionFactory(string resourceName = null, Action<Humidifier.EMRServerless.Session> factoryAction = null) : ResourceFactory<Humidifier.EMRServerless.Session>(resourceName)
{

    internal InnerSessionConfigurationOverridesFactory ConfigurationOverridesFactory { get; set; }

    protected override Humidifier.EMRServerless.Session Create()
    {
        var sessionResult = CreateSession();
        factoryAction?.Invoke(sessionResult);

        return sessionResult;
    }

    private Humidifier.EMRServerless.Session CreateSession()
    {
        var sessionResult = new Humidifier.EMRServerless.Session
        {
            GivenName = InputResourceName,
        };

        return sessionResult;
    }
    public override void CreateChildren(Humidifier.EMRServerless.Session result)
    {
        base.CreateChildren(result);

        result.ConfigurationOverrides ??= ConfigurationOverridesFactory?.Build();
    }

} // End Of Class

public static class SessionFactoryExtensions
{
    public static CombinedResult<SessionFactory, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides(this SessionFactory parentFactory, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null)
    {
        parentFactory.ConfigurationOverridesFactory = new InnerSessionConfigurationOverridesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ConfigurationOverridesFactory);
    }

    public static CombinedResult<SessionFactory, T1, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<SessionFactory, T1> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1>(this CombinedResult<T1, SessionFactory> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<SessionFactory, T1, T2> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, SessionFactory, T2> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2>(this CombinedResult<T1, T2, SessionFactory> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<SessionFactory, T1, T2, T3> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, SessionFactory, T2, T3> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, SessionFactory, T3> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3>(this CombinedResult<T1, T2, T3, SessionFactory> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<SessionFactory, T1, T2, T3, T4, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<SessionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, SessionFactory, T2, T3, T4, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, SessionFactory, T2, T3, T4> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, SessionFactory, T3, T4, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, SessionFactory, T3, T4> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, SessionFactory, T4, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SessionFactory, T4> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, SessionFactory, InnerSessionConfigurationOverridesFactory> WithConfigurationOverrides<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SessionFactory> combinedResult, Action<Humidifier.EMRServerless.SessionTypes.ConfigurationOverrides> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithConfigurationOverrides(combinedResult.T5, subFactoryAction).T2);
}
