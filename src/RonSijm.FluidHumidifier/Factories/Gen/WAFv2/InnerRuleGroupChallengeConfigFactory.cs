// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupChallengeConfigFactory(Action<Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig>
{

    internal InnerRuleGroupImmunityTimePropertyFactory ImmunityTimePropertyFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig Create()
    {
        var challengeConfigResult = CreateChallengeConfig();
        factoryAction?.Invoke(challengeConfigResult);

        return challengeConfigResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig CreateChallengeConfig()
    {
        var challengeConfigResult = new Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig();

        return challengeConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.ChallengeConfig result)
    {
        base.CreateChildren(result);

        result.ImmunityTimeProperty ??= ImmunityTimePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupChallengeConfigFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupChallengeConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty(this InnerRuleGroupChallengeConfigFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null)
    {
        parentFactory.ImmunityTimePropertyFactory = new InnerRuleGroupImmunityTimePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImmunityTimePropertyFactory);
    }

    public static CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<InnerRuleGroupChallengeConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<T1, InnerRuleGroupChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupChallengeConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupChallengeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupChallengeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupChallengeConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupChallengeConfigFactory, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupChallengeConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupChallengeConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T5, subFactoryAction));
}
