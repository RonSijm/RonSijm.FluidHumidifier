// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerInferenceExperimentCaptureContentTypeHeaderFactory(Action<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader>
{

    protected override Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader Create()
    {
        var captureContentTypeHeaderResult = CreateCaptureContentTypeHeader();
        factoryAction?.Invoke(captureContentTypeHeaderResult);

        return captureContentTypeHeaderResult;
    }

    private Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader CreateCaptureContentTypeHeader()
    {
        var captureContentTypeHeaderResult = new Humidifier.SageMaker.InferenceExperimentTypes.CaptureContentTypeHeader();

        return captureContentTypeHeaderResult;
    }

} // End Of Class

public static class InnerInferenceExperimentCaptureContentTypeHeaderFactoryExtensions
{
}
