// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class PricingRuleFactory(string resourceName = null, Action<Humidifier.BillingConductor.PricingRule> factoryAction = null) : ResourceFactory<Humidifier.BillingConductor.PricingRule>(resourceName)
{

    internal InnerPricingRuleTieringFactory TieringFactory { get; set; }

    protected override Humidifier.BillingConductor.PricingRule Create()
    {
        var pricingRuleResult = CreatePricingRule();
        factoryAction?.Invoke(pricingRuleResult);

        return pricingRuleResult;
    }

    private Humidifier.BillingConductor.PricingRule CreatePricingRule()
    {
        var pricingRuleResult = new Humidifier.BillingConductor.PricingRule
        {
            GivenName = InputResourceName,
        };

        return pricingRuleResult;
    }
    public override void CreateChildren(Humidifier.BillingConductor.PricingRule result)
    {
        base.CreateChildren(result);

        result.Tiering ??= TieringFactory?.Build();
    }

} // End Of Class

public static class PricingRuleFactoryExtensions
{
    public static CombinedResult<PricingRuleFactory, InnerPricingRuleTieringFactory> WithTiering(this PricingRuleFactory parentFactory, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null)
    {
        parentFactory.TieringFactory = new InnerPricingRuleTieringFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.TieringFactory);
    }

    public static CombinedResult<PricingRuleFactory, T1, InnerPricingRuleTieringFactory> WithTiering<T1>(this CombinedResult<PricingRuleFactory, T1> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, WithTiering(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PricingRuleFactory, InnerPricingRuleTieringFactory> WithTiering<T1>(this CombinedResult<T1, PricingRuleFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, WithTiering(combinedResult.T2, subFactoryAction));
    public static CombinedResult<PricingRuleFactory, T1, T2, InnerPricingRuleTieringFactory> WithTiering<T1, T2>(this CombinedResult<PricingRuleFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PricingRuleFactory, T2, InnerPricingRuleTieringFactory> WithTiering<T1, T2>(this CombinedResult<T1, PricingRuleFactory, T2> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PricingRuleFactory, InnerPricingRuleTieringFactory> WithTiering<T1, T2>(this CombinedResult<T1, T2, PricingRuleFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T3, subFactoryAction));
    public static CombinedResult<PricingRuleFactory, T1, T2, T3, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3>(this CombinedResult<PricingRuleFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PricingRuleFactory, T2, T3, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3>(this CombinedResult<T1, PricingRuleFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PricingRuleFactory, T3, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3>(this CombinedResult<T1, T2, PricingRuleFactory, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PricingRuleFactory, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3>(this CombinedResult<T1, T2, T3, PricingRuleFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T4, subFactoryAction));
    public static CombinedResult<PricingRuleFactory, T1, T2, T3, T4, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3, T4>(this CombinedResult<PricingRuleFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, PricingRuleFactory, T2, T3, T4, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3, T4>(this CombinedResult<T1, PricingRuleFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, PricingRuleFactory, T3, T4, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3, T4>(this CombinedResult<T1, T2, PricingRuleFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, PricingRuleFactory, T4, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, PricingRuleFactory, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, PricingRuleFactory, InnerPricingRuleTieringFactory> WithTiering<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, PricingRuleFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithTiering(combinedResult.T5, subFactoryAction));
}
