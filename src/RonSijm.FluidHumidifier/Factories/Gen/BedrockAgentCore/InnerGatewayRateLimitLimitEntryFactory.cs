// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRateLimitLimitEntryFactory(Action<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry>
{

    protected override Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry Create()
    {
        var limitEntryResult = CreateLimitEntry();
        factoryAction?.Invoke(limitEntryResult);

        return limitEntryResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry CreateLimitEntry()
    {
        var limitEntryResult = new Humidifier.BedrockAgentCore.GatewayRateLimitTypes.LimitEntry();

        return limitEntryResult;
    }

} // End Of Class

public static class InnerGatewayRateLimitLimitEntryFactoryExtensions
{
}
