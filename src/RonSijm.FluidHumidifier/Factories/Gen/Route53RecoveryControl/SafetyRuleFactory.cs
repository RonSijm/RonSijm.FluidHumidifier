// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Route53RecoveryControl;

public class SafetyRuleFactory(string resourceName = null, Action<Humidifier.Route53RecoveryControl.SafetyRule> factoryAction = null) : ResourceFactory<Humidifier.Route53RecoveryControl.SafetyRule>(resourceName)
{

    internal InnerSafetyRuleAssertionRuleFactory AssertionRuleFactory { get; set; }

    internal InnerSafetyRuleRuleConfigFactory RuleConfigFactory { get; set; }

    internal InnerSafetyRuleGatingRuleFactory GatingRuleFactory { get; set; }

    protected override Humidifier.Route53RecoveryControl.SafetyRule Create()
    {
        var safetyRuleResult = CreateSafetyRule();
        factoryAction?.Invoke(safetyRuleResult);

        return safetyRuleResult;
    }

    private Humidifier.Route53RecoveryControl.SafetyRule CreateSafetyRule()
    {
        var safetyRuleResult = new Humidifier.Route53RecoveryControl.SafetyRule
        {
            GivenName = InputResourceName,
        };

        return safetyRuleResult;
    }
    public override void CreateChildren(Humidifier.Route53RecoveryControl.SafetyRule result)
    {
        base.CreateChildren(result);

        result.AssertionRule ??= AssertionRuleFactory?.Build();
        result.RuleConfig ??= RuleConfigFactory?.Build();
        result.GatingRule ??= GatingRuleFactory?.Build();
    }

} // End Of Class

public static class SafetyRuleFactoryExtensions
{
    public static CombinedResult<SafetyRuleFactory, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule(this SafetyRuleFactory parentFactory, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null)
    {
        parentFactory.AssertionRuleFactory = new InnerSafetyRuleAssertionRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.AssertionRuleFactory);
    }

    public static CombinedResult<SafetyRuleFactory, InnerSafetyRuleRuleConfigFactory> WithRuleConfig(this SafetyRuleFactory parentFactory, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null)
    {
        parentFactory.RuleConfigFactory = new InnerSafetyRuleRuleConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RuleConfigFactory);
    }

    public static CombinedResult<SafetyRuleFactory, InnerSafetyRuleGatingRuleFactory> WithGatingRule(this SafetyRuleFactory parentFactory, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null)
    {
        parentFactory.GatingRuleFactory = new InnerSafetyRuleGatingRuleFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.GatingRuleFactory);
    }

    public static CombinedResult<SafetyRuleFactory, T1, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1>(this CombinedResult<SafetyRuleFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssertionRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1>(this CombinedResult<T1, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithAssertionRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2>(this CombinedResult<SafetyRuleFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2>(this CombinedResult<T1, SafetyRuleFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2>(this CombinedResult<T1, T2, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3>(this CombinedResult<SafetyRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3>(this CombinedResult<T1, SafetyRuleFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3>(this CombinedResult<T1, T2, SafetyRuleFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, T4, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3, T4>(this CombinedResult<SafetyRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, T4, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3, T4>(this CombinedResult<T1, SafetyRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, T4, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, SafetyRuleFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, T4, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SafetyRuleFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SafetyRuleFactory, InnerSafetyRuleAssertionRuleFactory> WithAssertionRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.AssertionRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithAssertionRule(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1>(this CombinedResult<SafetyRuleFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1>(this CombinedResult<T1, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithRuleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2>(this CombinedResult<SafetyRuleFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2>(this CombinedResult<T1, SafetyRuleFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2>(this CombinedResult<T1, T2, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3>(this CombinedResult<SafetyRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3>(this CombinedResult<T1, SafetyRuleFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3>(this CombinedResult<T1, T2, SafetyRuleFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, T4, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3, T4>(this CombinedResult<SafetyRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, T4, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3, T4>(this CombinedResult<T1, SafetyRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, T4, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, SafetyRuleFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, T4, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SafetyRuleFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SafetyRuleFactory, InnerSafetyRuleRuleConfigFactory> WithRuleConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.RuleConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRuleConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1>(this CombinedResult<SafetyRuleFactory, T1> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatingRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1>(this CombinedResult<T1, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, WithGatingRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2>(this CombinedResult<SafetyRuleFactory, T1, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2>(this CombinedResult<T1, SafetyRuleFactory, T2> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2>(this CombinedResult<T1, T2, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3>(this CombinedResult<SafetyRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3>(this CombinedResult<T1, SafetyRuleFactory, T2, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3>(this CombinedResult<T1, T2, SafetyRuleFactory, T3> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3>(this CombinedResult<T1, T2, T3, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<SafetyRuleFactory, T1, T2, T3, T4, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3, T4>(this CombinedResult<SafetyRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, SafetyRuleFactory, T2, T3, T4, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3, T4>(this CombinedResult<T1, SafetyRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, SafetyRuleFactory, T3, T4, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, SafetyRuleFactory, T3, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, SafetyRuleFactory, T4, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, SafetyRuleFactory, T4> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, SafetyRuleFactory, InnerSafetyRuleGatingRuleFactory> WithGatingRule<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, SafetyRuleFactory> combinedResult, Action<Humidifier.Route53RecoveryControl.SafetyRuleTypes.GatingRule> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithGatingRule(combinedResult.T5, subFactoryAction));
}
