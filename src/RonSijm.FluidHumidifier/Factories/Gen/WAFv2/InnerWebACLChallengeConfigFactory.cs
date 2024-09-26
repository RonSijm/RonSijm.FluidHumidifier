// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLChallengeConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.ChallengeConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.ChallengeConfig>
{

    internal InnerWebACLImmunityTimePropertyFactory ImmunityTimePropertyFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.ChallengeConfig Create()
    {
        var challengeConfigResult = CreateChallengeConfig();
        factoryAction?.Invoke(challengeConfigResult);

        return challengeConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.ChallengeConfig CreateChallengeConfig()
    {
        var challengeConfigResult = new Humidifier.WAFv2.WebACLTypes.ChallengeConfig();

        return challengeConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.ChallengeConfig result)
    {
        base.CreateChildren(result);

        result.ImmunityTimeProperty ??= ImmunityTimePropertyFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLChallengeConfigFactoryExtensions
{
    public static CombinedResult<InnerWebACLChallengeConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty(this InnerWebACLChallengeConfigFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null)
    {
        parentFactory.ImmunityTimePropertyFactory = new InnerWebACLImmunityTimePropertyFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ImmunityTimePropertyFactory);
    }

    public static CombinedResult<InnerWebACLChallengeConfigFactory, T1, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<InnerWebACLChallengeConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1>(this CombinedResult<T1, InnerWebACLChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2>(this CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory, T3, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLChallengeConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<InnerWebACLChallengeConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLChallengeConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory, T3, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLChallengeConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLChallengeConfigFactory, T4, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLChallengeConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLChallengeConfigFactory, InnerWebACLImmunityTimePropertyFactory> WithImmunityTimeProperty<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLChallengeConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ImmunityTimeProperty> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithImmunityTimeProperty(combinedResult.T5, subFactoryAction));
}
