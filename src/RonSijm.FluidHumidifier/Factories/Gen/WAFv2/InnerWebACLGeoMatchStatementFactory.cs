// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerWebACLGeoMatchStatementFactory(Action<Humidifier.WAFv2.WebACLTypes.GeoMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.WebACLTypes.GeoMatchStatement>
{

    internal InnerWebACLForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.WebACLTypes.GeoMatchStatement Create()
    {
        var geoMatchStatementResult = CreateGeoMatchStatement();
        factoryAction?.Invoke(geoMatchStatementResult);

        return geoMatchStatementResult;
    }

    private Humidifier.WAFv2.WebACLTypes.GeoMatchStatement CreateGeoMatchStatement()
    {
        var geoMatchStatementResult = new Humidifier.WAFv2.WebACLTypes.GeoMatchStatement();

        return geoMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.WebACLTypes.GeoMatchStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerWebACLGeoMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerWebACLGeoMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerWebACLGeoMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerWebACLForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerWebACLGeoMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerWebACLGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory, T3, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLGeoMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerWebACLGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerWebACLGeoMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerWebACLGeoMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory, T3, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerWebACLGeoMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerWebACLGeoMatchStatementFactory, T4, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerWebACLGeoMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerWebACLGeoMatchStatementFactory, InnerWebACLForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerWebACLGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.WebACLTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction));
}
