// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayInterceptorPayloadFilterFactory(Action<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter>
{

    protected override Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter Create()
    {
        var interceptorPayloadFilterResult = CreateInterceptorPayloadFilter();
        factoryAction?.Invoke(interceptorPayloadFilterResult);

        return interceptorPayloadFilterResult;
    }

    private Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter CreateInterceptorPayloadFilter()
    {
        var interceptorPayloadFilterResult = new Humidifier.BedrockAgentCore.GatewayTypes.InterceptorPayloadFilter();

        return interceptorPayloadFilterResult;
    }

} // End Of Class

public static class InnerGatewayInterceptorPayloadFilterFactoryExtensions
{
}
