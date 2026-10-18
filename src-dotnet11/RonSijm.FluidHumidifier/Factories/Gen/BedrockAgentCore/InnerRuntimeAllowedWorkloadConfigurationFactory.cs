// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerRuntimeAllowedWorkloadConfigurationFactory(Action<Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration>
{

    protected override Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration Create()
    {
        var allowedWorkloadConfigurationResult = CreateAllowedWorkloadConfiguration();
        factoryAction?.Invoke(allowedWorkloadConfigurationResult);

        return allowedWorkloadConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration CreateAllowedWorkloadConfiguration()
    {
        var allowedWorkloadConfigurationResult = new Humidifier.BedrockAgentCore.RuntimeTypes.AllowedWorkloadConfiguration();

        return allowedWorkloadConfigurationResult;
    }

} // End Of Class

public static class InnerRuntimeAllowedWorkloadConfigurationFactoryExtensions
{
}
