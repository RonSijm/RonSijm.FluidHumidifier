// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetKinesisStreamParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters Create()
    {
        var pipeTargetKinesisStreamParametersResult = CreatePipeTargetKinesisStreamParameters();
        factoryAction?.Invoke(pipeTargetKinesisStreamParametersResult);

        return pipeTargetKinesisStreamParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters CreatePipeTargetKinesisStreamParameters()
    {
        var pipeTargetKinesisStreamParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetKinesisStreamParameters();

        return pipeTargetKinesisStreamParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetKinesisStreamParametersFactoryExtensions
{
}
