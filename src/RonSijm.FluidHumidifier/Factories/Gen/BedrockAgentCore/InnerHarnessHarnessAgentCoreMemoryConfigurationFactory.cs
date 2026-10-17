// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessAgentCoreMemoryConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration Create()
    {
        var harnessAgentCoreMemoryConfigurationResult = CreateHarnessAgentCoreMemoryConfiguration();
        factoryAction?.Invoke(harnessAgentCoreMemoryConfigurationResult);

        return harnessAgentCoreMemoryConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration CreateHarnessAgentCoreMemoryConfiguration()
    {
        var harnessAgentCoreMemoryConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessAgentCoreMemoryConfiguration();

        return harnessAgentCoreMemoryConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessHarnessAgentCoreMemoryConfigurationFactoryExtensions
{
}
