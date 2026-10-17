// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DevOpsAgent;

public class InnerAgentSpacePreferencesFactory(Action<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences> factoryAction = null) : SubResourceFactory<Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences>
{

    protected override Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences Create()
    {
        var preferencesResult = CreatePreferences();
        factoryAction?.Invoke(preferencesResult);

        return preferencesResult;
    }

    private Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences CreatePreferences()
    {
        var preferencesResult = new Humidifier.DevOpsAgent.AgentSpaceTypes.Preferences();

        return preferencesResult;
    }

} // End Of Class

public static class InnerAgentSpacePreferencesFactoryExtensions
{
}
