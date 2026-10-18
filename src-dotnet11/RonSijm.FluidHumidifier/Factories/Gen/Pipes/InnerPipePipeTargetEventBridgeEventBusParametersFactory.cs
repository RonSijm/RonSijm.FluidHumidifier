// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetEventBridgeEventBusParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters Create()
    {
        var pipeTargetEventBridgeEventBusParametersResult = CreatePipeTargetEventBridgeEventBusParameters();
        factoryAction?.Invoke(pipeTargetEventBridgeEventBusParametersResult);

        return pipeTargetEventBridgeEventBusParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters CreatePipeTargetEventBridgeEventBusParameters()
    {
        var pipeTargetEventBridgeEventBusParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetEventBridgeEventBusParameters();

        return pipeTargetEventBridgeEventBusParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetEventBridgeEventBusParametersFactoryExtensions
{
}
