// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerRoutingRuleMatchBasePathsFactory(Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths>
{

    protected override Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths Create()
    {
        var matchBasePathsResult = CreateMatchBasePaths();
        factoryAction?.Invoke(matchBasePathsResult);

        return matchBasePathsResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths CreateMatchBasePaths()
    {
        var matchBasePathsResult = new Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths();

        return matchBasePathsResult;
    }

} // End Of Class

public static class InnerRoutingRuleMatchBasePathsFactoryExtensions
{
}
