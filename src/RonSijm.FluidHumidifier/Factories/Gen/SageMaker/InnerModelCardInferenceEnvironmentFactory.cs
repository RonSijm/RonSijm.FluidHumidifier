// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelCardInferenceEnvironmentFactory(Action<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment>
{

    protected override Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment Create()
    {
        var inferenceEnvironmentResult = CreateInferenceEnvironment();
        factoryAction?.Invoke(inferenceEnvironmentResult);

        return inferenceEnvironmentResult;
    }

    private Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment CreateInferenceEnvironment()
    {
        var inferenceEnvironmentResult = new Humidifier.SageMaker.ModelCardTypes.InferenceEnvironment();

        return inferenceEnvironmentResult;
    }

} // End Of Class

public static class InnerModelCardInferenceEnvironmentFactoryExtensions
{
}
