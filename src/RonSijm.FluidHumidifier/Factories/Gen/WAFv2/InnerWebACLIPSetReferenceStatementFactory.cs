// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLIPSetReferenceStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement>
{

    internal InnerWebACLIPSetForwardedIPConfigurationFactory IPSetForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement Create()
    {
        var iPSetReferenceStatementResult = CreateIPSetReferenceStatement();
        factoryAction?.Invoke(iPSetReferenceStatementResult);

        return iPSetReferenceStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement CreateIPSetReferenceStatement()
    {
        var iPSetReferenceStatementResult = new Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement();

        return iPSetReferenceStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.IPSetReferenceStatement result)
    {
        base.CreateChildren(result);

        result.IPSetForwardedIPConfig ??= IPSetForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLIPSetReferenceStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLIPSetReferenceStatementFactory, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig(this InnerWebACLIPSetReferenceStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.IPSetForwardedIPConfigFactory = new InnerWebACLIPSetForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.IPSetForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1>(this CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1>(this CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2, T3, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2, T3, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory, T3, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLIPSetReferenceStatementFactory, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2, T3, T4, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLIPSetReferenceStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2, T3, T4, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLIPSetReferenceStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory, T3, T4, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLIPSetReferenceStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLIPSetReferenceStatementFactory, T4, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLIPSetReferenceStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLIPSetReferenceStatementFactory, InnerWebACLIPSetForwardedIPConfigurationFactory> WithIPSetForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLIPSetReferenceStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.IPSetForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithIPSetForwardedIPConfig(combinedResult.T5, subFactoryAction));
}
