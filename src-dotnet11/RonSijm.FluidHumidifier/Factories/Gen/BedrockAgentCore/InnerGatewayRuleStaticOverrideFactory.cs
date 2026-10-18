// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleStaticOverrideFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride Create()
    {
        var staticOverrideResult = CreateStaticOverride();
        factoryAction?.Invoke(staticOverrideResult);

        return staticOverrideResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride CreateStaticOverride()
    {
        var staticOverrideResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.StaticOverride();

        return staticOverrideResult;
    }

} // End Of Class

public static class InnerGatewayRuleStaticOverrideFactoryExtensions
{
}
