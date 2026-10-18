// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BillingConductor;

public class InnerCustomLineItemCustomLineItemPercentageChargeDetailsFactory(Action<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails> factoryAction = null) : SubResourceFactory<Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails>
{

    protected override Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails Create()
    {
        var customLineItemPercentageChargeDetailsResult = CreateCustomLineItemPercentageChargeDetails();
        factoryAction?.Invoke(customLineItemPercentageChargeDetailsResult);

        return customLineItemPercentageChargeDetailsResult;
    }

    private Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails CreateCustomLineItemPercentageChargeDetails()
    {
        var customLineItemPercentageChargeDetailsResult = new Humidifier.BillingConductor.CustomLineItemTypes.CustomLineItemPercentageChargeDetails();

        return customLineItemPercentageChargeDetailsResult;
    }

} // End Of Class

public static class InnerCustomLineItemCustomLineItemPercentageChargeDetailsFactoryExtensions
{
}
