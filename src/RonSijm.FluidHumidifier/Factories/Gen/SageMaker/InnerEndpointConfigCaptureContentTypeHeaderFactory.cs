// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerEndpointConfigCaptureContentTypeHeaderFactory(Action<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader>
{

    protected override Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader Create()
    {
        var captureContentTypeHeaderResult = CreateCaptureContentTypeHeader();
        factoryAction?.Invoke(captureContentTypeHeaderResult);

        return captureContentTypeHeaderResult;
    }

    private Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader CreateCaptureContentTypeHeader()
    {
        var captureContentTypeHeaderResult = new Humidifier.SageMaker.EndpointConfigTypes.CaptureContentTypeHeader();

        return captureContentTypeHeaderResult;
    }

} // End Of Class

public static class InnerEndpointConfigCaptureContentTypeHeaderFactoryExtensions
{
}
