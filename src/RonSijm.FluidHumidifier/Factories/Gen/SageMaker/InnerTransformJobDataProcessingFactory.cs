// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerTransformJobDataProcessingFactory(Action<Humidifier.SageMaker.TransformJobTypes.DataProcessing> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.TransformJobTypes.DataProcessing>
{

    protected override Humidifier.SageMaker.TransformJobTypes.DataProcessing Create()
    {
        var dataProcessingResult = CreateDataProcessing();
        factoryAction?.Invoke(dataProcessingResult);

        return dataProcessingResult;
    }

    private Humidifier.SageMaker.TransformJobTypes.DataProcessing CreateDataProcessing()
    {
        var dataProcessingResult = new Humidifier.SageMaker.TransformJobTypes.DataProcessing();

        return dataProcessingResult;
    }

} // End Of Class

public static class InnerTransformJobDataProcessingFactoryExtensions
{
}
