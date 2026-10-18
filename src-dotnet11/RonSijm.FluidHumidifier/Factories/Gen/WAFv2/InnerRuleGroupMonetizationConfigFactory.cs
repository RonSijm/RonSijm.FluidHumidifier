// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupMonetizationConfigFactory(Action<Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig>
{

    internal InnerRuleGroupCryptoConfigFactory CryptoConfigFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig Create()
    {
        var monetizationConfigResult = CreateMonetizationConfig();
        factoryAction?.Invoke(monetizationConfigResult);

        return monetizationConfigResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig CreateMonetizationConfig()
    {
        var monetizationConfigResult = new Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig();

        return monetizationConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.MonetizationConfig result)
    {
        base.CreateChildren(result);

        result.CryptoConfig ??= CryptoConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupMonetizationConfigFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupMonetizationConfigFactory, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig(this InnerRuleGroupMonetizationConfigFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null)
    {
        parentFactory.CryptoConfigFactory = new InnerRuleGroupCryptoConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CryptoConfigFactory);
    }

    public static CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1>(this CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1>(this CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2, T3, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2, T3, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory, T3, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuleGroupMonetizationConfigFactory, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2, T3, T4, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupMonetizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2, T3, T4, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupMonetizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory, T3, T4, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupMonetizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuleGroupMonetizationConfigFactory, T4, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupMonetizationConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupMonetizationConfigFactory, InnerRuleGroupCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T5, subFactoryAction).T2);
}
