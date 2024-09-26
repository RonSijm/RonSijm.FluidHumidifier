// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetStateMachineParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters Create()
    {
        var pipeTargetStateMachineParametersResult = CreatePipeTargetStateMachineParameters();
        factoryAction?.Invoke(pipeTargetStateMachineParametersResult);

        return pipeTargetStateMachineParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters CreatePipeTargetStateMachineParameters()
    {
        var pipeTargetStateMachineParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetStateMachineParameters();

        return pipeTargetStateMachineParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetStateMachineParametersFactoryExtensions
{
}
