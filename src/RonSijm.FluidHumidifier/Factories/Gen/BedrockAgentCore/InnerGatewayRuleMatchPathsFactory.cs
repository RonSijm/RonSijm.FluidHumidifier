// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleMatchPathsFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths Create()
    {
        var matchPathsResult = CreateMatchPaths();
        factoryAction?.Invoke(matchPathsResult);

        return matchPathsResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths CreateMatchPaths()
    {
        var matchPathsResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths();

        return matchPathsResult;
    }

} // End Of Class

public static class InnerGatewayRuleMatchPathsFactoryExtensions
{
}
