// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceComponentInferenceComponentStartupParametersFactory(Action<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters>
{

    protected override Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters Create()
    {
        var inferenceComponentStartupParametersResult = CreateInferenceComponentStartupParameters();
        factoryAction?.Invoke(inferenceComponentStartupParametersResult);

        return inferenceComponentStartupParametersResult;
    }

    private Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters CreateInferenceComponentStartupParameters()
    {
        var inferenceComponentStartupParametersResult = new Humidifier.SageMaker.InferenceComponentTypes.InferenceComponentStartupParameters();

        return inferenceComponentStartupParametersResult;
    }

} // End Of Class

public static class InnerInferenceComponentInferenceComponentStartupParametersFactoryExtensions
{
}
