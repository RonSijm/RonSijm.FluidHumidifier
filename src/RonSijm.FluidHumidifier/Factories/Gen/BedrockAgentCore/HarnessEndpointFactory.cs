// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class HarnessEndpointFactory(string resourceName = null, Action<Humidifier.BedrockAgentCore.HarnessEndpoint> factoryAction = null) : ResourceFactory<Humidifier.BedrockAgentCore.HarnessEndpoint>(resourceName)
{

    protected override Humidifier.BedrockAgentCore.HarnessEndpoint Create()
    {
        var harnessEndpointResult = CreateHarnessEndpoint();
        factoryAction?.Invoke(harnessEndpointResult);

        return harnessEndpointResult;
    }

    private Humidifier.BedrockAgentCore.HarnessEndpoint CreateHarnessEndpoint()
    {
        var harnessEndpointResult = new Humidifier.BedrockAgentCore.HarnessEndpoint
        {
            GivenName = InputResourceName,
        };

        return harnessEndpointResult;
    }

} // End Of Class

public static class HarnessEndpointFactoryExtensions
{
}
