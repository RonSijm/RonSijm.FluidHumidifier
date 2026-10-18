// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeCapacityProviderVolumeConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration Create()
    {
        var capacityProviderVolumeConfigurationResult = CreateCapacityProviderVolumeConfiguration();
        factoryAction?.Invoke(capacityProviderVolumeConfigurationResult);

        return capacityProviderVolumeConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration CreateCapacityProviderVolumeConfiguration()
    {
        var capacityProviderVolumeConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.CapacityProviderVolumeConfiguration();

        return capacityProviderVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeCapacityProviderVolumeConfigurationFactoryExtensions
{
}
