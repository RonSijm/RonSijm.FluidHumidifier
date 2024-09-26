// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentGuardrailConfigurationFactory(Action<Humidifier.Bedrock.AgentTypes.GuardrailConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.GuardrailConfiguration>
{

    protected override Humidifier.Bedrock.AgentTypes.GuardrailConfiguration Create()
    {
        var guardrailConfigurationResult = CreateGuardrailConfiguration();
        factoryAction?.Invoke(guardrailConfigurationResult);

        return guardrailConfigurationResult;
    }

    private Humidifier.Bedrock.AgentTypes.GuardrailConfiguration CreateGuardrailConfiguration()
    {
        var guardrailConfigurationResult = new Humidifier.Bedrock.AgentTypes.GuardrailConfiguration();

        return guardrailConfigurationResult;
    }

} // End Of Class

public static class InnerAgentGuardrailConfigurationFactoryExtensions
{
}
