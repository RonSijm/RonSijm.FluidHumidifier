// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetSageMakerPipelineParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters Create()
    {
        var pipeTargetSageMakerPipelineParametersResult = CreatePipeTargetSageMakerPipelineParameters();
        factoryAction?.Invoke(pipeTargetSageMakerPipelineParametersResult);

        return pipeTargetSageMakerPipelineParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters CreatePipeTargetSageMakerPipelineParameters()
    {
        var pipeTargetSageMakerPipelineParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetSageMakerPipelineParameters();

        return pipeTargetSageMakerPipelineParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetSageMakerPipelineParametersFactoryExtensions
{
}
