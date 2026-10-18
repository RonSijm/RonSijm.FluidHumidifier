// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataPipeline;

public class InnerPipelinePipelineObjectFactory(Action<Humidifier.DataPipeline.PipelineTypes.PipelineObject> factoryAction = null) : SubResourceFactory<Humidifier.DataPipeline.PipelineTypes.PipelineObject>
{

    protected override Humidifier.DataPipeline.PipelineTypes.PipelineObject Create()
    {
        var pipelineObjectResult = CreatePipelineObject();
        factoryAction?.Invoke(pipelineObjectResult);

        return pipelineObjectResult;
    }

    private Humidifier.DataPipeline.PipelineTypes.PipelineObject CreatePipelineObject()
    {
        var pipelineObjectResult = new Humidifier.DataPipeline.PipelineTypes.PipelineObject();

        return pipelineObjectResult;
    }

} // End Of Class

public static class InnerPipelinePipelineObjectFactoryExtensions
{
}
