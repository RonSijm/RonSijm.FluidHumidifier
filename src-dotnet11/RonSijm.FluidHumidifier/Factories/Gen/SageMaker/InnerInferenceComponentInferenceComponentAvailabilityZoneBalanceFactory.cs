// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance Create()
    {
        var inferenceComponentAvailabilityZoneBalanceResult = CreateInferenceComponentAvailabilityZoneBalance();
        factoryAction?.Invoke(inferenceComponentAvailabilityZoneBalanceResult);

        return inferenceComponentAvailabilityZoneBalanceResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance CreateInferenceComponentAvailabilityZoneBalance()
    {
        var inferenceComponentAvailabilityZoneBalanceResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentAvailabilityZoneBalance();

        return inferenceComponentAvailabilityZoneBalanceResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentAvailabilityZoneBalanceFactoryExtensions
{
}
