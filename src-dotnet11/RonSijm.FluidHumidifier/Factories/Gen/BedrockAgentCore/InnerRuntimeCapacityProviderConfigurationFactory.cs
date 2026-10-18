// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeCapacityProviderConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration Create()
    {
        var capacityProviderConfigurationResult = CreateCapacityProviderConfiguration();
        factoryAction?.Invoke(capacityProviderConfigurationResult);

        return capacityProviderConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration CreateCapacityProviderConfiguration()
    {
        var capacityProviderConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderConfiguration();

        return capacityProviderConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeCapacityProviderConfigurationFactoryExtensions
{
}
