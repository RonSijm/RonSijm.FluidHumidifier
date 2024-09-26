// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupCaptchaConfigFactory(Action<Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig>
{

    internal InnerRuleGroupImmunityTimePropertyFactory ImmunityTimePropertyFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig Create()
    {
        var captchaConfigResult = CreateCaptchaConfig();
        factoryAction?.Invoke(captchaConfigResult);

        return captchaConfigResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig CreateCaptchaConfig()
    {
        var captchaConfigResult = new Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig();

        return captchaConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.CaptchaConfig result)
    {
        base.CreateChildren(result);

        result.ImmunityTimeProperty ??= ImmunityTimePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupCaptchaConfigFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupCaptchaConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty(this InnerRuleGroupCaptchaConfigFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null)
    {
        parentFactory.ImmunityTimePropertyFactory = new InnerRuleGroupImmunityTimePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImmunityTimePropertyFactory);
    }

    public static CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory, T3, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupCaptchaConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupCaptchaConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory, T3, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupCaptchaConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaConfigFactory, T4, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupCaptchaConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupCaptchaConfigFactory, InnerRuleGroupImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupCaptchaConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T5, subFactoryAction));
}
