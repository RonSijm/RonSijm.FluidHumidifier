// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleMatchPrincipalsFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals Create()
    {
        var matchPrincipalsResult = CreateMatchPrincipals();
        factoryAction?.Invoke(matchPrincipalsResult);

        return matchPrincipalsResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals CreateMatchPrincipals()
    {
        var matchPrincipalsResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals();

        return matchPrincipalsResult;
    }

} // End Of Class

public static class InnerGatewayRuleMatchPrincipalsFactoryExtensions
{
}
