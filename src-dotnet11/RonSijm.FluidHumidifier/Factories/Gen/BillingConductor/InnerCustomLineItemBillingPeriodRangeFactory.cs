// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerCustomLineItemBillingPeriodRangeFactory(Action<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange>
{

    protected override Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange Create()
    {
        var billingPeriodRangeResult = CreateBillingPeriodRange();
        factoryAction?.Invoke(billingPeriodRangeResult);

        return billingPeriodRangeResult;
    }

    private Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange CreateBillingPeriodRange()
    {
        var billingPeriodRangeResult = new Humidifier.BillingConductor.CustomLineItemTypes.BillingPeriodRange();

        return billingPeriodRangeResult;
    }

} // End Of Class

public static class InnerCustomLineItemBillingPeriodRangeFactoryExtensions
{
}
