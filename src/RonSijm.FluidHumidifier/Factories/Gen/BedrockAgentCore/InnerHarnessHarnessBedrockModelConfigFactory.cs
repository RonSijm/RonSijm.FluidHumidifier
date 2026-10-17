// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessBedrockModelConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig Create()
    {
        var harnessBedrockModelConfigResult = CreateHarnessBedrockModelConfig();
        factoryAction?.Invoke(harnessBedrockModelConfigResult);

        return harnessBedrockModelConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig CreateHarnessBedrockModelConfig()
    {
        var harnessBedrockModelConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessBedrockModelConfig();

        return harnessBedrockModelConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessBedrockModelConfigFactoryExtensions
{
}
