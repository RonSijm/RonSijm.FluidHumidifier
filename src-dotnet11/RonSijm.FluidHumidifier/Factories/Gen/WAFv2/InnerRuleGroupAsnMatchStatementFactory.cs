// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupAsnMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement>
{

    internal InnerRuleGroupForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement Create()
    {
        var asnMatchStatementResult = CreateAsnMatchStatement();
        factoryAction?.Invoke(asnMatchStatementResult);

        return asnMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement CreateAsnMatchStatement()
    {
        var asnMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement();

        return asnMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.AsnMatchStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupAsnMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupAsnMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerRuleGroupAsnMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerRuleGroupForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuleGroupAsnMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupAsnMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupAsnMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupAsnMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerRuleGroupAsnMatchStatementFactory, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupAsnMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupAsnMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction).T2);
}
