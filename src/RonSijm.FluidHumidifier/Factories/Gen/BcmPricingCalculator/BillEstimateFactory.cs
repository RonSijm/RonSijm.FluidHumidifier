// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BcmPricingCalculator;

public class BillEstimateFactory(string resourceName = null, Action<Humidifier.BcmPricingCalculator.BillEstimate> factoryAction = null) : ResourceFactory<Humidifier.BcmPricingCalculator.BillEstimate>(resourceName)
{

    protected override Humidifier.BcmPricingCalculator.BillEstimate Create()
    {
        var billEstimateResult = CreateBillEstimate();
        factoryAction?.Invoke(billEstimateResult);

        return billEstimateResult;
    }

    private Humidifier.BcmPricingCalculator.BillEstimate CreateBillEstimate()
    {
        var billEstimateResult = new Humidifier.BcmPricingCalculator.BillEstimate
        {
            GivenName = InputResourceName,
        };

        return billEstimateResult;
    }

} // End Of Class

public static class BillEstimateFactoryExtensions
{
}
