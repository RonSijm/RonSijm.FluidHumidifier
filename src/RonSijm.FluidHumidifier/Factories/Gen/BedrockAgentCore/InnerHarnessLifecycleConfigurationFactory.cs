// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerHarnessLifecycleConfigurationFactory(Action<Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration>
{

    protected override Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration Create()
    {
        var lifecycleConfigurationResult = CreateLifecycleConfiguration();
        factoryAction?.Invoke(lifecycleConfigurationResult);

        return lifecycleConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration CreateLifecycleConfiguration()
    {
        var lifecycleConfigurationResult = new Humidifier.BedrockAgentCore.HarnessTypes.LifecycleConfiguration();

        return lifecycleConfigurationResult;
    }

} // End Of Class

public static class InnerHarnessLifecycleConfigurationFactoryExtensions
{
}
