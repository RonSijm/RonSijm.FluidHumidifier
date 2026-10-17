// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayTargetApiGatewayToolConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration Create()
    {
        var apiGatewayToolConfigurationResult = CreateApiGatewayToolConfiguration();
        factoryAction?.Invoke(apiGatewayToolConfigurationResult);

        return apiGatewayToolConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration CreateApiGatewayToolConfiguration()
    {
        var apiGatewayToolConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTargetTypes.ApiGatewayToolConfiguration();

        return apiGatewayToolConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayTargetApiGatewayToolConfigurationFactoryExtensions
{
}
