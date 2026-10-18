// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BcmPricingCalculator;

public class BillScenarioFactory(string resourceName = null, Action<Humidifier.BcmPricingCalculator.BillScenario> factoryAction = null) : ResourceFactory<Humidifier.BcmPricingCalculator.BillScenario>(resourceName)
{

    protected override Humidifier.BcmPricingCalculator.BillScenario Create()
    {
        var billScenarioResult = CreateBillScenario();
        factoryAction?.Invoke(billScenarioResult);

        return billScenarioResult;
    }

    private Humidifier.BcmPricingCalculator.BillScenario CreateBillScenario()
    {
        var billScenarioResult = new Humidifier.BcmPricingCalculator.BillScenario
        {
            GivenName = InputResourceName,
        };

        return billScenarioResult;
    }

} // End Of Class

public static class BillScenarioFactoryExtensions
{
}
