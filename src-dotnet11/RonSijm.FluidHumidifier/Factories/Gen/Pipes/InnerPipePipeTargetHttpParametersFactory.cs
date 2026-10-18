// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetHttpParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters Create()
    {
        var pipeTargetHttpParametersResult = CreatePipeTargetHttpParameters();
        factoryAction?.Invoke(pipeTargetHttpParametersResult);

        return pipeTargetHttpParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters CreatePipeTargetHttpParameters()
    {
        var pipeTargetHttpParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetHttpParameters();

        return pipeTargetHttpParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetHttpParametersFactoryExtensions
{
}
