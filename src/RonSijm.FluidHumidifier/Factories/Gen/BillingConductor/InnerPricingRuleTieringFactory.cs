// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerPricingRuleTieringFactory(Action<Humidifier.BillingConductor.PricingRuleTypes.Tiering> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.PricingRuleTypes.Tiering>
{

    internal InnerPricingRuleFreeTierFactory FreeTierFactory { get; set; }

    protected override Humidifier.BillingConductor.PricingRuleTypes.Tiering Create()
    {
        var tieringResult = CreateTiering();
        factoryAction?.Invoke(tieringResult);

        return tieringResult;
    }

    private Humidifier.BillingConductor.PricingRuleTypes.Tiering CreateTiering()
    {
        var tieringResult = new Humidifier.BillingConductor.PricingRuleTypes.Tiering();

        return tieringResult;
    }
    public override void CreateChildren(Humidifier.BillingConductor.PricingRuleTypes.Tiering result)
    {
        base.CreateChildren(result);

        result.FreeTier ??= FreeTierFactory?.Build();
    }

} // End Of Class

public static class InnerPricingRuleTieringFactoryExtensions
{
    public static CombinedResult<InnerPricingRuleTieringFactory, InnerPricingRuleFreeTierFactory> WithFreeTier(this InnerPricingRuleTieringFactory parentFactory, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null)
    {
        parentFactory.FreeTierFactory = new InnerPricingRuleFreeTierFactory(subFactoryAction);
        return CombinedResultFactory.Create(parentFactory, parentFactory.FreeTierFactory);
    }

    public static CombinedResult<InnerPricingRuleTieringFactory, T1, InnerPricingRuleFreeTierFactory> WithFreeTier<T1>(this CombinedResult<InnerPricingRuleTieringFactory, T1> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, WithFreeTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPricingRuleTieringFactory, InnerPricingRuleFreeTierFactory> WithFreeTier<T1>(this CombinedResult<T1, InnerPricingRuleTieringFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, WithFreeTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<InnerPricingRuleTieringFactory, T1, T2, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2>(this CombinedResult<InnerPricingRuleTieringFactory, T1, T2> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPricingRuleTieringFactory, T2, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2>(this CombinedResult<T1, InnerPricingRuleTieringFactory, T2> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPricingRuleTieringFactory, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2>(this CombinedResult<T1, T2, InnerPricingRuleTieringFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<InnerPricingRuleTieringFactory, T1, T2, T3, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3>(this CombinedResult<InnerPricingRuleTieringFactory, T1, T2, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPricingRuleTieringFactory, T2, T3, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3>(this CombinedResult<T1, InnerPricingRuleTieringFactory, T2, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPricingRuleTieringFactory, T3, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3>(this CombinedResult<T1, T2, InnerPricingRuleTieringFactory, T3> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPricingRuleTieringFactory, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3>(this CombinedResult<T1, T2, T3, InnerPricingRuleTieringFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<InnerPricingRuleTieringFactory, T1, T2, T3, T4, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3, T4>(this CombinedResult<InnerPricingRuleTieringFactory, T1, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T1, subFactoryAction));
    public static CombinedResult<T1, InnerPricingRuleTieringFactory, T2, T3, T4, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3, T4>(this CombinedResult<T1, InnerPricingRuleTieringFactory, T2, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T2, subFactoryAction));
    public static CombinedResult<T1, T2, InnerPricingRuleTieringFactory, T3, T4, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, InnerPricingRuleTieringFactory, T3, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T3, subFactoryAction));
    public static CombinedResult<T1, T2, T3, InnerPricingRuleTieringFactory, T4, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, InnerPricingRuleTieringFactory, T4> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T4, subFactoryAction));
    public static CombinedResult<T1, T2, T3, T4, InnerPricingRuleTieringFactory, InnerPricingRuleFreeTierFactory> WithFreeTier<T1, T2, T3, T4>(this CombinedResult<T1, T2, T3, T4, InnerPricingRuleTieringFactory> combinedResult, Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> subFactoryAction = null) => new (combinedResult, combinedResult, combinedResult, combinedResult, combinedResult, WithFreeTier(combinedResult.T5, subFactoryAction));
}
