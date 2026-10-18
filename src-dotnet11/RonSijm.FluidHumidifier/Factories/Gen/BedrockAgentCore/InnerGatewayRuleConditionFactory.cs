// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BedrockAgentCore;

public class InnerGatewayRuleConditionFactory(Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition> factoryAction = null) : SubResourceFactory<Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition>
{

    internal InnerGatewayRuleMatchPathsFactory MatchPathsFactory { get; set; }

    internal InnerGatewayRuleMatchPrincipalsFactory MatchPrincipalsFactory { get; set; }

    protected override Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition Create()
    {
        var conditionResult = CreateCondition();
        factoryAction?.Invoke(conditionResult);

        return conditionResult;
    }

    private Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition CreateCondition()
    {
        var conditionResult = new Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition();

        return conditionResult;
    }
    public override void CreateChildren(Humidifier.BedrockAgentCore.GatewayRuleTypes.Condition result)
    {
        base.CreateChildren(result);

        result.MatchPaths ??= MatchPathsFactory?.Build();
        result.MatchPrincipals ??= MatchPrincipalsFactory?.Build();
    }

} // End Of Class

public static class InnerGatewayRuleConditionFactoryExtensions
{
    public static CombinedResult<InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPathsFactory> WithMatchPaths(this InnerGatewayRuleConditionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null)
    {
        parentFactory.MatchPathsFactory = new InnerGatewayRuleMatchPathsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPathsFactory);
    }

    public static CombinedResult<InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals(this InnerGatewayRuleConditionFactory parentFactory, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null)
    {
        parentFactory.MatchPrincipalsFactory = new InnerGatewayRuleMatchPrincipalsFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.MatchPrincipalsFactory);
    }

    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1>(this CombinedResult<InnerGatewayRuleConditionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1>(this CombinedResult<T1, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, T4, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, T4, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, T4, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, T4, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPathsFactory> WithMatchPaths<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPaths> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPaths(combinedResult.T5, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1>(this CombinedResult<InnerGatewayRuleConditionFactory, T1> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1>(this CombinedResult<T1, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, T4, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3, T4>(this CombinedResult<InnerGatewayRuleConditionFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, T4, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3, T4>(this CombinedResult<T1, InnerGatewayRuleConditionFactory, T2, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, T4, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerGatewayRuleConditionFactory, T3, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, T4, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerGatewayRuleConditionFactory, T4> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerGatewayRuleConditionFactory, InnerGatewayRuleMatchPrincipalsFactory> WithMatchPrincipals<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerGatewayRuleConditionFactory> combinedResult, Action<Humidifier.BedrockAgentCore.GatewayRuleTypes.MatchPrincipals> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithMatchPrincipals(combinedResult.T5, subFactoryAction).T2);
}
