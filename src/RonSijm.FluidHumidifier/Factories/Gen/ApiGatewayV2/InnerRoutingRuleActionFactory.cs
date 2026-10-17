// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerRoutingRuleActionFactory(Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.RoutingRuleTypes.Action>
{

    internal InnerRoutingRuleActionInvokeApiFactory InvokeApiFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.RoutingRuleTypes.Action Create()
    {
        var actionResult = CreateAction();
        factoryAction?.Invoke(actionResult);

        return actionResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRuleTypes.Action CreateAction()
    {
        var actionResult = new Humidifier.ApiGatewayV2.RoutingRuleTypes.Action();

        return actionResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.RoutingRuleTypes.Action result)
    {
        base.CreateChildren(result);

        result.InvokeApi ??= InvokeApiFactory?.Build();
    }

} // End Of Class

public static class InnerRoutingRuleActionFactoryExtensions
{
    public static CombinedResult<InnerRoutingRuleActionFactory, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi(this InnerRoutingRuleActionFactory parentFactory, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null)
    {
        parentFactory.InvokeApiFactory = new InnerRoutingRuleActionInvokeApiFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.InvokeApiFactory);
    }

    public static CombinedResult<InnerRoutingRuleActionFactory, T1, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1>(this CombinedResult<InnerRoutingRuleActionFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvokeApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleActionFactory, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1>(this CombinedResult<T1, InnerRoutingRuleActionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, WithInvokeApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleActionFactory, T1, T2, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2>(this CombinedResult<InnerRoutingRuleActionFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleActionFactory, T2, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2>(this CombinedResult<T1, InnerRoutingRuleActionFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleActionFactory, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2>(this CombinedResult<T1, T2, InnerRoutingRuleActionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleActionFactory, T1, T2, T3, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3>(this CombinedResult<InnerRoutingRuleActionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleActionFactory, T2, T3, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3>(this CombinedResult<T1, InnerRoutingRuleActionFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleActionFactory, T3, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingRuleActionFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleActionFactory, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingRuleActionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleActionFactory, T1, T2, T3, T4, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3, T4>(this CombinedResult<InnerRoutingRuleActionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleActionFactory, T2, T3, T4, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingRuleActionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleActionFactory, T3, T4, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingRuleActionFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleActionFactory, T4, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingRuleActionFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingRuleActionFactory, InnerRoutingRuleActionInvokeApiFactory> WithInvokeApi<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingRuleActionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.ActionInvokeApi> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithInvokeApi(combinedResult.T5, subFactoryAction).T2);
}
