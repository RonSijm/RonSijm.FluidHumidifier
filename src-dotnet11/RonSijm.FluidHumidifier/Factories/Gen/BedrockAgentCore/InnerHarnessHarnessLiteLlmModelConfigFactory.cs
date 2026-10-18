// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessLiteLlmModelConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig Create()
    {
        var harnessLiteLlmModelConfigResult = CreateHarnessLiteLlmModelConfig();
        factoryAction?.Invoke(harnessLiteLlmModelConfigResult);

        return harnessLiteLlmModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig CreateHarnessLiteLlmModelConfig()
    {
        var harnessLiteLlmModelConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessLiteLlmModelConfig();

        return harnessLiteLlmModelConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessLiteLlmModelConfigFactoryExtensions
{
}
