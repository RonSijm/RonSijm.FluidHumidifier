// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleStaticRouteFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute Create()
    {
        var staticRouteResult = CreateStaticRoute();
        factoryAction?.Invoke(staticRouteResult);

        return staticRouteResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute CreateStaticRoute()
    {
        var staticRouteResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticRoute();

        return staticRouteResult;
    }

} // End Of Class

public static class InnerGatewayRuleStaticRouteFactoryExtensions
{
}
