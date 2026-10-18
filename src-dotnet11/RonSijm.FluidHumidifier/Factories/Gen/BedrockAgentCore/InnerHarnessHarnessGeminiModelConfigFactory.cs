// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessGeminiModelConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig Create()
    {
        var harnessGeminiModelConfigResult = CreateHarnessGeminiModelConfig();
        factoryAction?.Invoke(harnessGeminiModelConfigResult);

        return harnessGeminiModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig CreateHarnessGeminiModelConfig()
    {
        var harnessGeminiModelConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessGeminiModelConfig();

        return harnessGeminiModelConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessGeminiModelConfigFactoryExtensions
{
}
