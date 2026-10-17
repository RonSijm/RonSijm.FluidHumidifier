// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.SageMaker;

public class PipelineExecutionFactory(string resourceName = null, Action<Humidifier.SageMaker.PipelineExecution> factoryAction = null) : ResourceFactory<Humidifier.SageMaker.PipelineExecution>(resourceName)
{

    protected override Humidifier.SageMaker.PipelineExecution Create()
    {
        var pipelineExecutionResult = CreatePipelineExecution();
        factoryAction?.Invoke(pipelineExecutionResult);

        return pipelineExecutionResult;
    }

    private Humidifier.SageMaker.PipelineExecution CreatePipelineExecution()
    {
        var pipelineExecutionResult = new Humidifier.SageMaker.PipelineExecution
        {
            GivenName = InputResourceName,
        };

        return pipelineExecutionResult;
    }

} // End Of Class

public static class PipelineExecutionFactoryExtensions
{
}
