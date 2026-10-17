// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetInferenceConnectorSourceFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource Create()
    {
        var inferenceConnectorSourceResult = CreateInferenceConnectorSource();
        factoryAction?.Invoke(inferenceConnectorSourceResult);

        return inferenceConnectorSourceResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource CreateInferenceConnectorSource()
    {
        var inferenceConnectorSourceResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.InferenceConnectorSource();

        return inferenceConnectorSourceResult;
    }

} // End Of Class

public static class InnerGatewayTargetInferenceConnectorSourceFactoryExtensions
{
}
