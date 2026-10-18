// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentComputeResourceRequirementsFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements Create()
    {
        var inferenceComponentComputeResourceRequirementsResult = CreateInferenceComponentComputeResourceRequirements();
        factoryAction?.Invoke(inferenceComponentComputeResourceRequirementsResult);

        return inferenceComponentComputeResourceRequirementsResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements CreateInferenceComponentComputeResourceRequirements()
    {
        var inferenceComponentComputeResourceRequirementsResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentComputeResourceRequirements();

        return inferenceComponentComputeResourceRequirementsResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentComputeResourceRequirementsFactoryExtensions
{
}
