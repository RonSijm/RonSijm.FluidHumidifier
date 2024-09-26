// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelPackageInferenceSpecificationFactory(Action<Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification>
{

    protected override Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification Create()
    {
        var inferenceSpecificationResult = CreateInferenceSpecification();
        factoryAction?.Invoke(inferenceSpecificationResult);

        return inferenceSpecificationResult;
    }

    private Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification CreateInferenceSpecification()
    {
        var inferenceSpecificationResult = new Humidifier.SageMaker.ModelPackageTypes.InferenceSpecification();

        return inferenceSpecificationResult;
    }

} // End Of Class

public static class InnerModelPackageInferenceSpecificationFactoryExtensions
{
}
