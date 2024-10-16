// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLRuleFactory(Action<Humidifier.WAFv2.WebACLTypes.Rule> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.Rule>
{

    internal InnerWebACLRuleActionFactory ActionFactory { get; set; }

    internal InnerWebACLStatementFactory StatementFactory { get; set; }

    internal InnerWebACLChallengeConfigFactory ChallengeConfigFactory { get; set; }

    internal InnerWebACLOverrideActionFactory OverrideActionFactory { get; set; }

    internal InnerWebACLVisibilityConfigFactory VisibilityConfigFactory { get; set; }

    internal InnerWebACLCaptchaConfigFactory CaptchaConfigFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.WAFv2.WebACLTypes.Rule CreateRule()
    {
        var ruleResult = new Humidifier.WAFv2.WebACLTypes.Rule();

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.Rule result)
    {
        base.CreateChildren(result);

        result.Action ??= ActionFactory?.Build();
        result.Statement ??= StatementFactory?.Build();
        result.ChallengeConfig ??= ChallengeConfigFactory?.Build();
        result.OverrideAction ??= OverrideActionFactory?.Build();
        result.VisibilityConfig ??= VisibilityConfigFactory?.Build();
        result.CaptchaConfig ??= CaptchaConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLRuleFactoryExtensions
{
    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLRuleActionFactory> WithAction(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null)
    {
        parentFactory.ActionFactory = new InnerWebACLRuleActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ActionFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLStatementFactory> WithStatement(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null)
    {
        parentFactory.StatementFactory = new InnerWebACLStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.StatementFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLChallengeConfigFactory> WithChallengeConfig(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null)
    {
        parentFactory.ChallengeConfigFactory = new InnerWebACLChallengeConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ChallengeConfigFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLOverrideActionFactory> WithOverrideAction(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null)
    {
        parentFactory.OverrideActionFactory = new InnerWebACLOverrideActionFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.OverrideActionFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null)
    {
        parentFactory.VisibilityConfigFactory = new InnerWebACLVisibilityConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.VisibilityConfigFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig(this InnerWebACLRuleFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null)
    {
        parentFactory.CaptchaConfigFactory = new InnerWebACLCaptchaConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CaptchaConfigFactory);
    }

    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLRuleActionFactory> WithAction<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLRuleActionFactory> WithAction<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLRuleActionFactory> WithAction<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLRuleActionFactory> WithAction<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLRuleActionFactory> WithAction<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLRuleActionFactory> WithAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.RuleAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLStatementFactory> WithStatement<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLStatementFactory> WithStatement<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLStatementFactory> WithStatement<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLStatementFactory> WithStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLStatementFactory> WithStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithStatement(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithChallengeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithChallengeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLChallengeConfigFactory> WithChallengeConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithChallengeConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLOverrideActionFactory> WithOverrideAction<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrideAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLOverrideActionFactory> WithOverrideAction<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, WithOverrideAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLOverrideActionFactory> WithOverrideAction<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.OverrideAction> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithOverrideAction(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLVisibilityConfigFactory> WithVisibilityConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.VisibilityConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithVisibilityConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1>(this CombinedResult<InnerWebACLRuleFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1>(this CombinedResult<T1, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2>(this CombinedResult<InnerWebACLRuleFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2>(this CombinedResult<T1, InnerWebACLRuleFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRuleFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRuleFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory, InnerWebACLCaptchaConfigFactory> WithCaptchaConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRuleFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CaptchaConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCaptchaConfig(combinedResult.T5, subFactoryAction));
}
