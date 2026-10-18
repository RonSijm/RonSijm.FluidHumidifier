// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetTimestreamParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters Create()
    {
        var pipeTargetTimestreamParametersResult = CreatePipeTargetTimestreamParameters();
        factoryAction?.Invoke(pipeTargetTimestreamParametersResult);

        return pipeTargetTimestreamParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters CreatePipeTargetTimestreamParameters()
    {
        var pipeTargetTimestreamParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetTimestreamParameters();

        return pipeTargetTimestreamParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetTimestreamParametersFactoryExtensions
{
}
