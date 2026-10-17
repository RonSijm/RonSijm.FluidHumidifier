// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class RuntimeEndpointFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.RuntimeEndpoint> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.RuntimeEndpoint>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.RuntimeEndpoint Create()
    {
        var runtimeEndpointResult = CreateRuntimeEndpoint();
        factoryAction?.Invoke(runtimeEndpointResult);

        return runtimeEndpointResult;
    }

    private Humidifier.BedrockAgentCore.RuntimeEndpoint CreateRuntimeEndpoint()
    {
        var runtimeEndpointResult = new Humidifier.BedrockAgentCore.RuntimeEndpoint
        {
            GivenName = InputResourceName,
        };

        return runtimeEndpointResult;
    }

} // End Of Class

public static class RuntimeEndpointFactoryExtensions
{
}
