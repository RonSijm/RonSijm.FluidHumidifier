// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerRoutingRuleActionInvokeApiFactory(Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi>
{

    protected override Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi Create()
    {
        var actionInvokeApiResult = CreateActionInvokeApi();
        factoryAction?.Invoke(actionInvokeApiResult);

        return actionInvokeApiResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi CreateActionInvokeApi()
    {
        var actionInvokeApiResult = new Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi();

        return actionInvokeApiResult;
    }

} // End Of Class

public static class InnerRoutingRuleActionInvokeApiFactoryExtensions
{
}
