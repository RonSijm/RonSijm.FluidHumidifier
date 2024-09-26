// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupRateBasedStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement>
{

    internal InnerRuleGroupForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    internal InnerRuleGroupStatementFactory ScopeDownStatementFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement Create()
    {
        var rateBasedStatementResult = CreateRateBasedStatement();
        factoryAction?.Invoke(rateBasedStatementResult);

        return rateBasedStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement CreateRateBasedStatement()
    {
        var rateBasedStatementResult = new Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement();

        return rateBasedStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.RateBasedStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
        result.ScopeDownStatement ??= ScopeDownStatementFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupRateBasedStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerRuleGroupRateBasedStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerRuleGroupForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupStatementFactory> WithScopeDownStatement(this InnerRuleGroupRateBasedStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null)
    {
        parentFactory.ScopeDownStatementFactory = new InnerRuleGroupStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeDownStatementFactory);
    }

    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, T4, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupRateBasedStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, T4, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupRateBasedStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, T4, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupRateBasedStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, T4, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupRateBasedStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupRateBasedStatementFactory, InnerRuleGroupStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T5, subFactoryAction));
}
