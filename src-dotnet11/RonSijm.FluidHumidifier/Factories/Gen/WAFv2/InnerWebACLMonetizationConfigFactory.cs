// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLMonetizationConfigFactory(Action<Humidifier.WAFv2.WebACLTypes.MonetizationConfig> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.MonetizationConfig>
{

    internal InnerWebACLCryptoConfigFactory CryptoConfigFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.MonetizationConfig Create()
    {
        var monetizationConfigResult = CreateMonetizationConfig();
        factoryAction?.Invoke(monetizationConfigResult);

        return monetizationConfigResult;
    }

    private Humidifier.WAFv2.WebACLTypes.MonetizationConfig CreateMonetizationConfig()
    {
        var monetizationConfigResult = new Humidifier.WAFv2.WebACLTypes.MonetizationConfig();

        return monetizationConfigResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.MonetizationConfig result)
    {
        base.CreateChildren(result);

        result.CryptoConfig ??= CryptoConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLMonetizationConfigFactoryExtensions
{
    public static CombinedResult<InnerWebACLMonetizationConfigFactory, InnerWebACLCryptoConfigFactory> WithCryptoConfig(this InnerWebACLMonetizationConfigFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null)
    {
        parentFactory.CryptoConfigFactory = new InnerWebACLCryptoConfigFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.CryptoConfigFactory);
    }

    public static CombinedResult<InnerWebACLMonetizationConfigFactory, T1, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1>(this CombinedResult<InnerWebACLMonetizationConfigFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLMonetizationConfigFactory, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1>(this CombinedResult<T1, InnerWebACLMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2, T3, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2, T3, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory, T3, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebACLMonetizationConfigFactory, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2, T3, T4, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLMonetizationConfigFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T1, subFactoryAction).T2);
    public static CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2, T3, T4, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLMonetizationConfigFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T2, subFactoryAction).T2);
    public static CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory, T3, T4, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLMonetizationConfigFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T3, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, InnerWebACLMonetizationConfigFactory, T4, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLMonetizationConfigFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T4, subFactoryAction).T2);
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLMonetizationConfigFactory, InnerWebACLCryptoConfigFactory> WithCryptoConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLMonetizationConfigFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.CryptoConfig> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithCryptoConfig(combinedResult.T5, subFactoryAction).T2);
}
