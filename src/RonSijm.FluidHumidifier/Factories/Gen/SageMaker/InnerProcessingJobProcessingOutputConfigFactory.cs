// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerProcessingJobProcessingOutputConfigFactory(Action<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig>
{

    protected override Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig Create()
    {
        var processingOutputConfigResult = CreateProcessingOutputConfig();
        factoryAction?.Invoke(processingOutputConfigResult);

        return processingOutputConfigResult;
    }

    private Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig CreateProcessingOutputConfig()
    {
        var processingOutputConfigResult = new Humidifier.SageMaker.ProcessingJobTypes.ProcessingOutputConfig();

        return processingOutputConfigResult;
    }

} // End Of Class

public static class InnerProcessingJobProcessingOutputConfigFactoryExtensions
{
}
