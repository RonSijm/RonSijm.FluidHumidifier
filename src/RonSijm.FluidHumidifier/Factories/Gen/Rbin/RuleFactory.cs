// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Rbin;

public class RuleFactory(string resourceName = null, Action<Humidifier.Rbin.Rule> factoryAction = null) : ResourceFactory<Humidifier.Rbin.Rule>(resourceName)
{

    internal List<InnerRuleResourceTagFactory> ResourceTagsFactories { get; set; } = [];

    internal List<InnerRuleResourceTagFactory> ExcludeResourceTagsFactories { get; set; } = [];

    internal InnerRuleUnlockDelayFactory LockConfigurationFactory { get; set; }

    internal InnerRuleRetentionPeriodFactory RetentionPeriodFactory { get; set; }

    protected override Humidifier.Rbin.Rule Create()
    {
        var ruleResult = CreateRule();
        factoryAction?.Invoke(ruleResult);

        return ruleResult;
    }

    private Humidifier.Rbin.Rule CreateRule()
    {
        var ruleResult = new Humidifier.Rbin.Rule
        {
            GivenName = InputResourceName,
        };

        return ruleResult;
    }
    public override void CreateChildren(Humidifier.Rbin.Rule result)
    {
        base.CreateChildren(result);

        result.ResourceTags = ResourceTagsFactories.Any() ? ResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.ExcludeResourceTags = ExcludeResourceTagsFactories.Any() ? ExcludeResourceTagsFactories.Select(x => x.Build()).ToList() : null;
        result.LockConfiguration ??= LockConfigurationFactory?.Build();
        result.RetentionPeriod ??= RetentionPeriodFactory?.Build();
    }

} // End Of Class

public static class RuleFactoryExtensions
{
    public static CombinedResult<RuleFactory, InnerRuleResourceTagFactory> WithResourceTags(this RuleFactory parentFactory, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerRuleResourceTagFactory(subFactoryAction);
        parentFactory.ResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleFactory, InnerRuleResourceTagFactory> WithExcludeResourceTags(this RuleFactory parentFactory, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null)
    {
        var factory = new InnerRuleResourceTagFactory(subFactoryAction);
        parentFactory.ExcludeResourceTagsFactories.Add(factory);
        return CombinedResultFactory.Create(parentFactory, factory);
    }
    public static CombinedResult<RuleFactory, InnerRuleUnlockDelayFactory> WithLockConfiguration(this RuleFactory parentFactory, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null)
    {
        parentFactory.LockConfigurationFactory = new InnerRuleUnlockDelayFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.LockConfigurationFactory);
    }

    public static CombinedResult<RuleFactory, InnerRuleRetentionPeriodFactory> WithRetentionPeriod(this RuleFactory parentFactory, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null)
    {
        parentFactory.RetentionPeriodFactory = new InnerRuleRetentionPeriodFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.RetentionPeriodFactory);
    }

    public static CombinedResult<RuleFactory, T1, InnerRuleResourceTagFactory> WithResourceTags<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleResourceTagFactory> WithResourceTags<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleResourceTagFactory> WithResourceTags<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleResourceTagFactory> WithResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleResourceTagFactory> WithExcludeResourceTags<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.ResourceTag> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithExcludeResourceTags(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleUnlockDelayFactory> WithLockConfiguration<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.UnlockDelay> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithLockConfiguration(combinedResult.T5, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<RuleFactory, T1> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1>(this CombinedResult<T1, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<RuleFactory, T1, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, RuleFactory, T2> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2>(this CombinedResult<T1, T2, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<RuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, RuleFactory, T2, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, RuleFactory, T3> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3>(this CombinedResult<T1, T2, T3, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<RuleFactory, T1, T2, T3, T4, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<RuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, RuleFactory, T2, T3, T4, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, RuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, RuleFactory, T3, T4, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, RuleFactory, T3, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, RuleFactory, T4, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, RuleFactory, T4> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, RuleFactory, InnerRuleRetentionPeriodFactory> WithRetentionPeriod<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, RuleFactory> combinedResult, Action<Humidifier.Rbin.RuleTypes.RetentionPeriod> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithRetentionPeriod(combinedResult.T5, subFactoryAction));
}
