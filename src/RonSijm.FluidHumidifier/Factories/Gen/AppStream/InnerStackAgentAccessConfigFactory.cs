// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.AppStream;

public class InnerStackAgentAccessConfigFactory(Action<Humidifier.AppStream.StackTypes.AgentAccessConfig> factoryAction = null) : SubResourceFactory<Humidifier.AppStream.StackTypes.AgentAccessConfig>
{

    protected override Humidifier.AppStream.StackTypes.AgentAccessConfig Create()
    {
        var agentAccessConfigResult = CreateAgentAccessConfig();
        factoryAction?.Invoke(agentAccessConfigResult);

        return agentAccessConfigResult;
    }

    private Humidifier.AppStream.StackTypes.AgentAccessConfig CreateAgentAccessConfig()
    {
        var agentAccessConfigResult = new Humidifier.AppStream.StackTypes.AgentAccessConfig();

        return agentAccessConfigResult;
    }

} // End Of Class

public static class InnerStackAgentAccessConfigFactoryExtensions
{
}
