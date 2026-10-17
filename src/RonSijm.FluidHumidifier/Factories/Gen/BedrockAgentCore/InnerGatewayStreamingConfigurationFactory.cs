// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayStreamingConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration Create()
    {
        var streamingConfigurationResult = CreateStreamingConfiguration();
        factoryAction?.Invoke(streamingConfigurationResult);

        return streamingConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration CreateStreamingConfiguration()
    {
        var streamingConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.StreamingConfiguration();

        return streamingConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayStreamingConfigurationFactoryExtensions
{
}
