// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeContainerConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration Create()
    {
        var containerConfigurationResult = CreateContainerConfiguration();
        factoryAction?.Invoke(containerConfigurationResult);

        return containerConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration CreateContainerConfiguration()
    {
        var containerConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.ContainerConfiguration();

        return containerConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeContainerConfigurationFactoryExtensions
{
}
