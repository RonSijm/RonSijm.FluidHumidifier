// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobDataCaptureConfigFactory(Action<Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig>
{

    protected override Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig Create()
    {
        var dataCaptureConfigResult = CreateDataCaptureConfig();
        factoryAction?.Invoke(dataCaptureConfigResult);

        return dataCaptureConfigResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig CreateDataCaptureConfig()
    {
        var dataCaptureConfigResult = new Humidifier.SageMaker.TransformJobTypes.DataCaptureConfig();

        return dataCaptureConfigResult;
    }

} // End Of Class

public static class InnerTransformJobDataCaptureConfigFactoryExtensions
{
}
