// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleWeightedRouteFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute Create()
    {
        var weightedRouteResult = CreateWeightedRoute();
        factoryAction?.Invoke(weightedRouteResult);

        return weightedRouteResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute CreateWeightedRoute()
    {
        var weightedRouteResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedRoute();

        return weightedRouteResult;
    }

} // End Of Class

public static class InnerGatewayRuleWeightedRouteFactoryExtensions
{
}
