// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataBrew;

public class RulesetFactory(string resourceName = null, Action<Humidifier.DataBrew.Ruleset> factoryAction = null) : ResourceFactory<Humidifier.DataBrew.Ruleset>(resourceName)
{

    internal List<InnerRulesetRuleFactory> RulesFactories { get; set; } = [];

    protected override Humidifier.DataBrew.Ruleset Create()
    {
        var rulesetResult = CreateRuleset();
        factoryAction?.Invoke(rulesetResult);

        return rulesetResult;
    }

    private Humidifier.DataBrew.Ruleset CreateRuleset()
    {
        var rulesetResult = new Humidifier.DataBrew.Ruleset
        {
            GivenName = InputResourceName,
        };

        return rulesetResult;
    }
    public override void CreateChildren(Humidifier.DataBrew.Ruleset result)
    {
        base.CreateChildren(result);

        result.Rules = RulesFactories.Any() ? RulesFactories.Select(x => x.Build()).ToList() : null;
    }

} // End Of Class

public static class RulesetFactoryExtensions
{
    public static CombinedResult<RulesetFactory, InnerRulesetRuleFactory> WithRules(this RulesetFactory parentFactory, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null)
    {
        var factory = new InnerRulesetRuleFactory(subFactoryAction);
        parentFactory.RulesFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RulesetFactory, T1, InnerRulesetRuleFactory> WithRules<T1>(this CombinedResult<RulesetFactory, T1> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RulesetFactory, InnerRulesetRuleFactory> WithRules<T1>(this CombinedResult<T1, RulesetFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RulesetFactory, T1, T2, InnerRulesetRuleFactory> WithRules<T1, T2>(this CombinedResult<RulesetFactory, T1, T2> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RulesetFactory, T2, InnerRulesetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, RulesetFactory, T2> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RulesetFactory, InnerRulesetRuleFactory> WithRules<T1, T2>(this CombinedResult<T1, T2, RulesetFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RulesetFactory, T1, T2, T3, InnerRulesetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<RulesetFactory, T1, T2, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RulesetFactory, T2, T3, InnerRulesetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, RulesetFactory, T2, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RulesetFactory, T3, InnerRulesetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, RulesetFactory, T3> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RulesetFactory, InnerRulesetRuleFactory> WithRules<T1, T2, T3>(this CombinedResult<T1, T2, T3, RulesetFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RulesetFactory, T1, T2, T3, T4, InnerRulesetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<RulesetFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RulesetFactory, T2, T3, T4, InnerRulesetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, RulesetFactory, T2, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RulesetFactory, T3, T4, InnerRulesetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, RulesetFactory, T3, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RulesetFactory, T4, InnerRulesetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RulesetFactory, T4> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RulesetFactory, InnerRulesetRuleFactory> WithRules<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RulesetFactory> combinedResult, Action<Humidifier.DataBrew.RulesetTypes.Rule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRules(combinedResult.T5, subFactoryAction));
}
