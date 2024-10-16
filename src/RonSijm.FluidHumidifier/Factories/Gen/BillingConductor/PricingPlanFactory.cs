// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class PricingPlanFactory(string resourceName = null, Action<Humidifier.BillingConductor.PricingPlan> factoryAction = null) : ResourceFactory<Humidifier.BillingConductor.PricingPlan>(resourceName)
{

    protected override Humidifier.BillingConductor.PricingPlan Create()
    {
        var pricingPlanResult = CreatePricingPlan();
        factoryAction?.Invoke(pricingPlanResult);

        return pricingPlanResult;
    }

    private Humidifier.BillingConductor.PricingPlan CreatePricingPlan()
    {
        var pricingPlanResult = new Humidifier.BillingConductor.PricingPlan
        {
            GivenName = InputResourceName,
        };

        return pricingPlanResult;
    }

} // End Of Class

public static class PricingPlanFactoryExtensions
{
}
