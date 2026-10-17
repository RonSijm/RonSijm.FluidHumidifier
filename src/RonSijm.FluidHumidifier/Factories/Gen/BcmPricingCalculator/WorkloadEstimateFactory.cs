// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.BcmPricingCalculator;

public class WorkloadEstimateFactory(string resourceName = null, Action<Humidifier.BcmPricingCalculator.WorkloadEstimate> factoryAction = null) : ResourceFactory<Humidifier.BcmPricingCalculator.WorkloadEstimate>(resourceName)
{

    protected override Humidifier.BcmPricingCalculator.WorkloadEstimate Create()
    {
        var workloadEstimateResult = CreateWorkloadEstimate();
        factoryAction?.Invoke(workloadEstimateResult);

        return workloadEstimateResult;
    }

    private Humidifier.BcmPricingCalculator.WorkloadEstimate CreateWorkloadEstimate()
    {
        var workloadEstimateResult = new Humidifier.BcmPricingCalculator.WorkloadEstimate
        {
            GivenName = InputResourceName,
        };

        return workloadEstimateResult;
    }

} // End Of Class

public static class WorkloadEstimateFactoryExtensions
{
}
