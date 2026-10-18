// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class InnerPipelineParallelismConfigurationFactory(Action<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration> factoryAction = null) : SubResourceFactory<Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration>
{

    protected override Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration Create()
    {
        var parallelismConfigurationResult = CreateParallelismConfiguration();
        factoryAction?.Invoke(parallelismConfigurationResult);

        return parallelismConfigurationResult;
    }

    private Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration CreateParallelismConfiguration()
    {
        var parallelismConfigurationResult = new Humidifier.SageMaker.PipelineTypes.ParallelismConfiguration();

        return parallelismConfigurationResult;
    }

} // End Of Class

public static class InnerPipelineParallelismConfigurationFactoryExtensions
{
}
