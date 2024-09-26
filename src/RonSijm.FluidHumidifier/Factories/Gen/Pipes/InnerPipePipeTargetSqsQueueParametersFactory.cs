// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetSqsQueueParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters Create()
    {
        var pipeTargetSqsQueueParametersResult = CreatePipeTargetSqsQueueParameters();
        factoryAction?.Invoke(pipeTargetSqsQueueParametersResult);

        return pipeTargetSqsQueueParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters CreatePipeTargetSqsQueueParameters()
    {
        var pipeTargetSqsQueueParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetSqsQueueParameters();

        return pipeTargetSqsQueueParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetSqsQueueParametersFactoryExtensions
{
}
