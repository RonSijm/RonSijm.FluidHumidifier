// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Bedrock;

public class InnerAgentPromptOverrideConfigurationFactory(Action<Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration>
{

    protected override Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration Create()
    {
        var promptOverrideConfigurationResult = CreatePromptOverrideConfiguration();
        factoryAction?.Invoke(promptOverrideConfigurationResult);

        return promptOverrideConfigurationResult;
    }

    private Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration CreatePromptOverrideConfiguration()
    {
        var promptOverrideConfigurationResult = new Humidifier.Bedrock.AgentTypes.PromptOverrideConfiguration();

        return promptOverrideConfigurationResult;
    }

} // End Of Class

public static class InnerAgentPromptOverrideConfigurationFactoryExtensions
{
}
