// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerCapacityProviderInstanceLifecycleConfigurationFactory(Action<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration>
{

    protected override Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration Create()
    {
        var instanceLifecycleConfigurationResult = CreateInstanceLifecycleConfiguration();
        factoryAction?.Invoke(instanceLifecycleConfigurationResult);

        return instanceLifecycleConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration CreateInstanceLifecycleConfiguration()
    {
        var instanceLifecycleConfigurationResult = new Humidifier.BedrockAgentCore.CapacityProviderTypes.InstanceLifecycleConfiguration();

        return instanceLifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerCapacityProviderInstanceLifecycleConfigurationFactoryExtensions
{
}
