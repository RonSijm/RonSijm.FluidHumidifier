// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerModelInferenceExecutionConfigFactory(Action<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig>
{

    protected override Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig Create()
    {
        var inferenceExecutionConfigResult = CreateInferenceExecutionConfig();
        factoryAction?.Invoke(inferenceExecutionConfigResult);

        return inferenceExecutionConfigResult;
    }

    private Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig CreateInferenceExecutionConfig()
    {
        var inferenceExecutionConfigResult = new Humidifier.SageMaker.ModelTypes.InferenceExecutionConfig();

        return inferenceExecutionConfigResult;
    }

} // End Of Class

public static class InnerModelInferenceExecutionConfigFactoryExtensions
{
}
