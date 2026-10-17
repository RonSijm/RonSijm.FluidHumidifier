// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessContainerConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration Create()
    {
        var containerConfigurationResult = CreateContainerConfiguration();
        factoryAction?.Invoke(containerConfigurationResult);

        return containerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration CreateContainerConfiguration()
    {
        var containerConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.ContainerConfiguration();

        return containerConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessContainerConfigurationFactoryExtensions
{
}
