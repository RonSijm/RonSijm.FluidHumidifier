// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeLifecycleConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeLifecycleConfigurationFactoryExtensions
{
}
