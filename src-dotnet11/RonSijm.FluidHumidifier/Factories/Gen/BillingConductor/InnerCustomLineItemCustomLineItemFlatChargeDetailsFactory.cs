// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerCustomLineItemCustomLineItemFlatChargeDetailsFactory(Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails>
{

    protected override Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails Create()
    {
        var customLineItemFlatChargeDetailsResult = CreateCustomLineItemFlatChargeDetails();
        factoryAction?.Invoke(customLineItemFlatChargeDetailsResult);

        return customLineItemFlatChargeDetailsResult;
    }

    private Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails CreateCustomLineItemFlatChargeDetails()
    {
        var customLineItemFlatChargeDetailsResult = new Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemFlatChargeDetails();

        return customLineItemFlatChargeDetailsResult;
    }

} // End Of Class

public static class InnerCustomLineItemCustomLineItemFlatChargeDetailsFactoryExtensions
{
}
