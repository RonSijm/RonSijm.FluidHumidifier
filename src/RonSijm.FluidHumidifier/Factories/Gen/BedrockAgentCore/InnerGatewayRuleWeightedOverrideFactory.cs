// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleWeightedOverrideFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride Create()
    {
        var weightedOverrideResult = CreateWeightedOverride();
        factoryAction?.Invoke(weightedOverrideResult);

        return weightedOverrideResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride CreateWeightedOverride()
    {
        var weightedOverrideResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.WeightedOverride();

        return weightedOverrideResult;
    }

} // End Of Class

public static class InnerGatewayRuleWeightedOverrideFactoryExtensions
{
}
