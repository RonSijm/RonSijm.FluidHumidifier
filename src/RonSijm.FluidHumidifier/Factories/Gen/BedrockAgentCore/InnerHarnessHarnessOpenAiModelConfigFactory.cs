// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessOpenAiModelConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig Create()
    {
        var harnessOpenAiModelConfigResult = CreateHarnessOpenAiModelConfig();
        factoryAction?.Invoke(harnessOpenAiModelConfigResult);

        return harnessOpenAiModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig CreateHarnessOpenAiModelConfig()
    {
        var harnessOpenAiModelConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessOpenAiModelConfig();

        return harnessOpenAiModelConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessOpenAiModelConfigFactoryExtensions
{
}
