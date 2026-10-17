// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessInlineFunctionConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig Create()
    {
        var harnessInlineFunctionConfigResult = CreateHarnessInlineFunctionConfig();
        factoryAction?.Invoke(harnessInlineFunctionConfigResult);

        return harnessInlineFunctionConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig CreateHarnessInlineFunctionConfig()
    {
        var harnessInlineFunctionConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessInlineFunctionConfig();

        return harnessInlineFunctionConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessInlineFunctionConfigFactoryExtensions
{
}
