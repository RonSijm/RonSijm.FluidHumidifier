// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLAsnMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.AsnMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.AsnMatchStatement>
{

    internal InnerWebACLForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.AsnMatchStatement Create()
    {
        var asnMatchStatementResult = CreateAsnMatchStatement();
        factoryAction?.Invoke(asnMatchStatementResult);

        return asnMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.AsnMatchStatement CreateAsnMatchStatement()
    {
        var asnMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.AsnMatchStatement();

        return asnMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.AsnMatchStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLAsnMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLAsnMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerWebACLAsnMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerWebACLForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerWebACLAsnMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerWebACLAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebACLAsnMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLAsnMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLAsnMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLAsnMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebACLAsnMatchStatementFactory, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLAsnMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLAsnMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLAsnMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction).T2);
}
