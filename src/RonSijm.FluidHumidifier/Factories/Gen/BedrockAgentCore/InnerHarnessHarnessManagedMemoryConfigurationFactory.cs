// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessHarnessManagedMemoryConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration Create()
    {
        var harnessManagedMemoryConfigurationResult = CreateHarnessManagedMemoryConfiguration();
        factoryAction?.Invoke(harnessManagedMemoryConfigurationResult);

        return harnessManagedMemoryConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration CreateHarnessManagedMemoryConfiguration()
    {
        var harnessManagedMemoryConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.HarnessManagedMemoryConfiguration();

        return harnessManagedMemoryConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessHarnessManagedMemoryConfigurationFactoryExtensions
{
}
