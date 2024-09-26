// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupIPSetReferenceStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement>
{

    internal InnerRuleGroupIPSetForwardedIPConfigurationFactory IPSetForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement Create()
    {
        var iPSetReferenceStatementResult = CreateIPSetReferenceStatement();
        factoryAction?.Invoke(iPSetReferenceStatementResult);

        return iPSetReferenceStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement CreateIPSetReferenceStatement()
    {
        var iPSetReferenceStatementResult = new Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement();

        return iPSetReferenceStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.IPSetReferenceStatement result)
    {
        base.CreateChildren(result);

        result.IPSetForwardedIPConfig ??= IPSetForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupIPSetReferenceStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig(this InnerRuleGroupIPSetReferenceStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.IPSetForwardedIPConfigFactory = new InnerRuleGroupIPSetForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IPSetForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1>(this CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1>(this CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2, T3, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2, T3, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory, T3, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupIPSetReferenceStatementFactory, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2, T3, T4, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupIPSetReferenceStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2, T3, T4, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupIPSetReferenceStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory, T3, T4, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupIPSetReferenceStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupIPSetReferenceStatementFactory, T4, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupIPSetReferenceStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupIPSetReferenceStatementFactory, InnerRuleGroupIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T5, subFactoryAction));
}
