// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ApiGatewayV2;

public class InnerRoutingRuleConditionFactory(Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition> factoryAction = null) : SubResourceFactory<Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition>
{

    internal InnerRoutingRuleMatchBasePathsFactory MatchBasePathsFactory { get; set; }

    internal InnerRoutingRuleMatchHeadersFactory MatchHeadersFactory { get; set; }

    protected override Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition Create()
    {
        var conditionResult = CreateCondition();
        factoryAction?.Invoke(conditionResult);

        return conditionResult;
    }

    private Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition CreateCondition()
    {
        var conditionResult = new Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition();

        return conditionResult;
    }
    public override void CreateChildren(Humidifier.ApiGatewayV2.RoutingRuleTypes.Condition result)
    {
        base.CreateChildren(result);

        result.MatchBasePaths ??= MatchBasePathsFactory?.Build();
        result.MatchHeaders ??= MatchHeadersFactory?.Build();
    }

} // End Of Class

public static class InnerRoutingRuleConditionFactoryExtensions
{
    public static CombinedResult<InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths(this InnerRoutingRuleConditionFactory parentFactory, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null)
    {
        parentFactory.MatchBasePathsFactory = new InnerRoutingRuleMatchBasePathsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchBasePathsFactory);
    }

    public static CombinedResult<InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders(this InnerRoutingRuleConditionFactory parentFactory, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null)
    {
        parentFactory.MatchHeadersFactory = new InnerRoutingRuleMatchHeadersFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchHeadersFactory);
    }

    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1>(this CombinedResult<InnerRoutingRuleConditionFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1>(this CombinedResult<T1, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, T4, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3, T4>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, T4, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, T4, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, T4, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchBasePathsFactory> WithMatchBasePaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchBasePaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchBasePaths(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1>(this CombinedResult<InnerRoutingRuleConditionFactory, T1> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchHeaders(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1>(this CombinedResult<T1, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchHeaders(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, T4, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3, T4>(this CombinedResult<InnerRoutingRuleConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, T4, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3, T4>(this CombinedResult<T1, InnerRoutingRuleConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, T4, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRoutingRuleConditionFactory, T3, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, T4, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRoutingRuleConditionFactory, T4> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRoutingRuleConditionFactory, InnerRoutingRuleMatchHeadersFactory> WithMatchHeaders<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRoutingRuleConditionFactory> combinedResult, Action<Humidifier.ApiGatewayV2.RoutingRuleTypes.MatchHeaders> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchHeaders(combinedResult.T5, subFactoryAction).T2);
}
