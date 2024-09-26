// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipePipeTargetCloudWatchLogsParametersFactory(Action<Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters>
{

    protected override Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters Create()
    {
        var pipeTargetCloudWatchLogsParametersResult = CreatePipeTargetCloudWatchLogsParameters();
        factoryAction?.Invoke(pipeTargetCloudWatchLogsParametersResult);

        return pipeTargetCloudWatchLogsParametersResult;
    }

    private Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters CreatePipeTargetCloudWatchLogsParameters()
    {
        var pipeTargetCloudWatchLogsParametersResult = new Humidifier.Pipes.PipeTypes.PipeTargetCloudWatchLogsParameters();

        return pipeTargetCloudWatchLogsParametersResult;
    }

} // End Of Class

public static class InnerPipePipeTargetCloudWatchLogsParametersFactoryExtensions
{
}
