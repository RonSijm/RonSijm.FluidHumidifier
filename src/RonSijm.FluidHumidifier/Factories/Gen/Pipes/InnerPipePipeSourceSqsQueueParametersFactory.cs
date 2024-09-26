// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeSourceSqsQueueParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters Create()
    {
        var pipeSourceSqsQueueParametersResult = CreatePipeSourceSqsQueueParameters();
        factoryAction?.Invoke(pipeSourceSqsQueueParametersResult);

        return pipeSourceSqsQueueParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters CreatePipeSourceSqsQueueParameters()
    {
        var pipeSourceSqsQueueParametersResult = new Humidifier.Pipes.PipeTypes.PipeSourceSqsQueueParameters();

        return pipeSourceSqsQueueParametersResult;
    }

} // End Of Class

public static class InnerPipePipeSourceSqsQueueParametersFactoryExtensions
{
}
