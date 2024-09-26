// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLRateBasedStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.RateBasedStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.RateBasedStatement>
{

    internal InnerWebACLForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    internal InnerWebACLStatementFactory ScopeDownStatementFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.RateBasedStatement Create()
    {
        var rateBasedStatementResult = CreateRateBasedStatement();
        factoryAction?.Invoke(rateBasedStatementResult);

        return rateBasedStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.RateBasedStatement CreateRateBasedStatement()
    {
        var rateBasedStatementResult = new Humidifier.WAFv2.WebACLTypes.RateBasedStatement();

        return rateBasedStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.RateBasedStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
        result.ScopeDownStatement ??= ScopeDownStatementFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLRateBasedStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerWebACLRateBasedStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerWebACLForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerWebACLRateBasedStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement(this InnerWebACLRateBasedStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null)
    {
        parentFactory.ScopeDownStatementFactory = new InnerWebACLStatementFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ScopeDownStatementFactory);
    }

    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRateBasedStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, InnerWebACLStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<InnerWebACLRateBasedStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLRateBasedStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLRateBasedStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, T4, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLRateBasedStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLRateBasedStatementFactory, InnerWebACLStatementFactory> WithScopeDownStatement<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLRateBasedStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.Statement> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithScopeDownStatement(combinedResult.T5, subFactoryAction));
}
