// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class AgentSpaceFactory(string resourceName = null, Action<Humidifier.DevOpsAgent.AgentSpace> factoryAction = null) : ResourceFactory<Humidifier.DevOpsAgent.AgentSpace>(resourceName)
{

    internal InnerAgentSpaceOperatorAppFactory OperatorAppFactory { get; set; }

    internal InnerAgentSpacePreferencesFactory PreferencesFactory { get; set; }

    protected override Humidifier.DevOpsAgent.AgentSpace Create()
    {
        var agentSpaceResult = CreateAgentSpace();
        factoryAction?.Invoke(agentSpaceResult);

        return agentSpaceResult;
    }

    private Humidifier.DevOpsAgent.AgentSpace CreateAgentSpace()
    {
        var agentSpaceResult = new Humidifier.DevOpsAgent.AgentSpace
        {
            GivenName = InputResourceName,
        };

        return agentSpaceResult;
    }
    public override void CreateChildren(Humidifier.DevOpsAgent.AgentSpace result)
    {
        base.CreateChildren(result);

        result.OperatorApp ??= OperatorAppFactory?.Build();
        result.Preferences ??= PreferencesFactory?.Build();
    }

} // End Of Class

public static class AgentSpaceFactoryExtensions
{
    public static CombinedResult<AgentSpaceFactory, InnerAgentSpaceOperatorAppFactory> WithOperatorApp(this AgentSpaceFactory parentFactory, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null)
    {
        parentFactory.OperatorAppFactory = new InnerAgentSpaceOperatorAppFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OperatorAppFactory);
    }

    public static CombinedResult<AgentSpaceFactory, InnerAgentSpacePreferencesFactory> WithPreferences(this AgentSpaceFactory parentFactory, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null)
    {
        parentFactory.PreferencesFactory = new InnerAgentSpacePreferencesFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.PreferencesFactory);
    }

    public static CombinedResult<AgentSpaceFactory, T1, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1>(this CombinedResult<AgentSpaceFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatorApp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1>(this CombinedResult<T1, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, WithOperatorApp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2>(this CombinedResult<AgentSpaceFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2>(this CombinedResult<T1, AgentSpaceFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2>(this CombinedResult<T1, T2, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3>(this CombinedResult<AgentSpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3>(this CombinedResult<T1, AgentSpaceFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3>(this CombinedResult<T1, T2, AgentSpaceFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, T4, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3, T4>(this CombinedResult<AgentSpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, T4, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3, T4>(this CombinedResult<T1, AgentSpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, T4, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentSpaceFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, T4, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentSpaceFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentSpaceFactory, InnerAgentSpaceOperatorAppFactory> WithOperatorApp<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.OperatorApp> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOperatorApp(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, InnerAgentSpacePreferencesFactory> WithPreferences<T1>(this CombinedResult<AgentSpaceFactory, T1> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, InnerAgentSpacePreferencesFactory> WithPreferences<T1>(this CombinedResult<T1, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, WithPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2>(this CombinedResult<AgentSpaceFactory, T1, T2> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2>(this CombinedResult<T1, AgentSpaceFactory, T2> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2>(this CombinedResult<T1, T2, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3>(this CombinedResult<AgentSpaceFactory, T1, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3>(this CombinedResult<T1, AgentSpaceFactory, T2, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3>(this CombinedResult<T1, T2, AgentSpaceFactory, T3> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3>(this CombinedResult<T1, T2, T3, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<AgentSpaceFactory, T1, T2, T3, T4, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3, T4>(this CombinedResult<AgentSpaceFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, AgentSpaceFactory, T2, T3, T4, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3, T4>(this CombinedResult<T1, AgentSpaceFactory, T2, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, AgentSpaceFactory, T3, T4, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, AgentSpaceFactory, T3, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, AgentSpaceFactory, T4, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, AgentSpaceFactory, T4> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, AgentSpaceFactory, InnerAgentSpacePreferencesFactory> WithPreferences<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, AgentSpaceFactory> combinedResult, Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithPreferences(combinedResult.T5, subFactoryAction).T2);
}
