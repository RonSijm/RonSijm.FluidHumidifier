// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerRoutingRuleMatchHeadersFactory(Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders>
{

    protected override Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders Create()
    {
        var matchHeadersResult = CreateMatchHeaders();
        factoryAction?.Invoke(matchHeadersResult);

        return matchHeadersResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders CreateMatchHeaders()
    {
        var matchHeadersResult = new Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders();

        return matchHeadersResult;
    }

} // End Of Class

public static class InnerRoutingRuleMatchHeadersFactoryExtensions
{
}
