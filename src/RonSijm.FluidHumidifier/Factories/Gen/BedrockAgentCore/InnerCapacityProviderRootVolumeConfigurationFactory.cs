// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderRootVolumeConfigurationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration Create()
    {
        var rootVolumeConfigurationResult = CreateRootVolumeConfiguration();
        factoryAction?.Invoke(rootVolumeConfigurationResult);

        return rootVolumeConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration CreateRootVolumeConfiguration()
    {
        var rootVolumeConfigurationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.RootVolumeConfiguration();

        return rootVolumeConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderRootVolumeConfigurationFactoryExtensions
{
}
