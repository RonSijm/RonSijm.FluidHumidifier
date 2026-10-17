// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAgentCoreBrowserConfigFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig Create()
    {
        var harnessAgentCoreBrowserConfigResult = CreateHarnessAgentCoreBrowserConfig();
        factoryAction?.Invoke(harnessAgentCoreBrowserConfigResult);

        return harnessAgentCoreBrowserConfigResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig CreateHarnessAgentCoreBrowserConfig()
    {
        var harnessAgentCoreBrowserConfigResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreBrowserConfig();

        return harnessAgentCoreBrowserConfigResult;
    }

} // End Of Class

public static class InnerHarnessHarnessAgentCoreBrowserConfigFactoryExtensions
{
}
