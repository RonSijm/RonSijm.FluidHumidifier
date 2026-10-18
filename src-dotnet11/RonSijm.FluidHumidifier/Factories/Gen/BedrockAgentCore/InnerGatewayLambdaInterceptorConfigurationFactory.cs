// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayLambdaInterceptorConfigurationFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration Create()
    {
        var lambdaInterceptorConfigurationResult = CreateLambdaInterceptorConfiguration();
        factoryAction?.Invoke(lambdaInterceptorConfigurationResult);

        return lambdaInterceptorConfigurationResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration CreateLambdaInterceptorConfiguration()
    {
        var lambdaInterceptorConfigurationResult = new Humidifier.BedrockAgentCore.GatewayTypes.LambdaInterceptorConfiguration();

        return lambdaInterceptorConfigurationResult;
    }

} // End Of Class

public static class InnerGatewayLambdaInterceptorConfigurationFactoryExtensions
{
}
