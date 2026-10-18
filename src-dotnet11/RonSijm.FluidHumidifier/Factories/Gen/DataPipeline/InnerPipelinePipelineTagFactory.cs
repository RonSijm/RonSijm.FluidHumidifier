// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.DataPipeline;

public class InnerPipelinePipelineTagFactory(Action<Humidifier.DataPipeline.PipelineTypes.PipelineTag> factoryAction = null) : SubResourceFactory<Humidifier.DataPipeline.PipelineTypes.PipelineTag>
{

    protected override Humidifier.DataPipeline.PipelineTypes.PipelineTag Create()
    {
        var pipelineTagResult = CreatePipelineTag();
        factoryAction?.Invoke(pipelineTagResult);

        return pipelineTagResult;
    }

    private Humidifier.DataPipeline.PipelineTypes.PipelineTag CreatePipelineTag()
    {
        var pipelineTagResult = new Humidifier.DataPipeline.PipelineTypes.PipelineTag();

        return pipelineTagResult;
    }

} // End Of Class

public static class InnerPipelinePipelineTagFactoryExtensions
{
}
