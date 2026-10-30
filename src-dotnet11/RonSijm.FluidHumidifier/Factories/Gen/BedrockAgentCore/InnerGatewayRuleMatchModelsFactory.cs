// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleMatchModelsFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels>
{

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels Create()
    {
        var matchModelsResult = CreateMatchModels();
        factoryAction?.Invoke(matchModelsResult);

        return matchModelsResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels CreateMatchModels()
    {
        var matchModelsResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchModels();

        return matchModelsResult;
    }

} // End Of Class

public static class InnerGatewayRuleMatchModelsFactoryExtensions
{
}
