// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.WAFv2;

public class InnerRuleGroupGeoMatchStatementFactory(Action<Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement> factoryAction = null) : SubResourceFactory<Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement>
{

    internal InnerRuleGroupForwardedIPConfigurationFactory ForwardedIPConfigFactory { get; set; }

    protected override Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement Create()
    {
        var geoMatchStatementResult = CreateGeoMatchStatement();
        factoryAction?.Invoke(geoMatchStatementResult);

        return geoMatchStatementResult;
    }

    private Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement CreateGeoMatchStatement()
    {
        var geoMatchStatementResult = new Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement();

        return geoMatchStatementResult;
    }
    public override void CreateChildren(Humidifier.WAFv2.RuleGroupTypes.GeoMatchStatement result)
    {
        base.CreateChildren(result);

        result.ForwardedIPConfig ??= ForwardedIPConfigFactory?.Build();
    }

} // End Of Class

public static class InnerRuleGroupGeoMatchStatementFactoryExtensions
{
    public static CombinedResult<InnerRuleGroupGeoMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig(this InnerRuleGroupGeoMatchStatementFactory parentFactory, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null)
    {
        parentFactory.ForwardedIPConfigFactory = new InnerRuleGroupForwardedIPConfigurationFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.ForwardedIPConfigFactory);
    }

    public static CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1>(this CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2>(this CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory, T3, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory, T3> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupGeoMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerRuleGroupGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<InnerRuleGroupGeoMatchStatementFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, InnerRuleGroupGeoMatchStatementFactory, T2, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory, T3, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerRuleGroupGeoMatchStatementFactory, T3, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerRuleGroupGeoMatchStatementFactory, T4, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerRuleGroupGeoMatchStatementFactory, T4> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerRuleGroupGeoMatchStatementFactory, InnerRuleGroupForwardedIPConfigurationFactory> WithForwardedIPConfig<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerRuleGroupGeoMatchStatementFactory> combinedResult, Action<Humidifier.WAFv2.RuleGroupTypes.ForwardedIPConfiguration> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithForwardedIPConfig(combinedResult.T5, subFactoryAction));
}
