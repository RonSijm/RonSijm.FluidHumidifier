// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerPricingRuleFreeTierFactory(Action<Humidifier.BillingConductor.PricingRuleTypes.FreeTier> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.PricingRuleTypes.FreeTier>
{

    protected override Humidifier.BillingConductor.PricingRuleTypes.FreeTier Create()
    {
        var freeTierResult = CreateFreeTier();
        factoryAction?.Invoke(freeTierResult);

        return freeTierResult;
    }

    private Humidifier.BillingConductor.PricingRuleTypes.FreeTier CreateFreeTier()
    {
        var freeTierResult = new Humidifier.BillingConductor.PricingRuleTypes.FreeTier();

        return freeTierResult;
    }

} // End Of Class

public static class InnerPricingRuleFreeTierFactoryExtensions
{
}
