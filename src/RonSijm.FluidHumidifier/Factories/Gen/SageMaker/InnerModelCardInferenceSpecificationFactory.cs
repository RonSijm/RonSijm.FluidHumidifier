// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardInferenceSpecificationFactory(Action<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.InferenceSpecification>
{

    protected override Humidifier.SageMaker.ModelCardTypes.InferenceSpecification Create()
    {
        var inferenceSpecificationResult = CreateInferenceSpecification();
        factoryAction?.Invoke(inferenceSpecificationResult);

        return inferenceSpecificationResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.InferenceSpecification CreateInferenceSpecification()
    {
        var inferenceSpecificationResult = new Humidifier.SageMaker.ModelCardTypes.InferenceSpecification();

        return inferenceSpecificationResult;
    }

} // End Of Class

public static class InnerModelCardInferenceSpecificationFactoryExtensions
{
}
