// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.RTBFabric;

public class InnerLinkRoutingRuleQueryStringKeyValuePairFactory(Action<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair> factoryAction = null) : SubResourceFactory<Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair>
{

    protected override Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair Create()
    {
        var queryStringKeyValuePairResult = CreateQueryStringKeyValuePair();
        factoryAction?.Invoke(queryStringKeyValuePairResult);

        return queryStringKeyValuePairResult;
    }

    private Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair CreateQueryStringKeyValuePair()
    {
        var queryStringKeyValuePairResult = new Humidifier.RTBFabric.LinkRoutingRuleTypes.QueryStringKeyValuePair();

        return queryStringKeyValuePairResult;
    }

} // End Of Class

public static class InnerLinkRoutingRuleQueryStringKeyValuePairFactoryExtensions
{
}
