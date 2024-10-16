// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeCloudwatchLogsLogDestinationFactory(Action<Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination>
{

    protected override Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination Create()
    {
        var cloudwatchLogsLogDestinationResult = CreateCloudwatchLogsLogDestination();
        factoryAction?.Invoke(cloudwatchLogsLogDestinationResult);

        return cloudwatchLogsLogDestinationResult;
    }

    private Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination CreateCloudwatchLogsLogDestination()
    {
        var cloudwatchLogsLogDestinationResult = new Humidifier.Pipes.PipeTypes.CloudwatchLogsLogDestination();

        return cloudwatchLogsLogDestinationResult;
    }

} // End Of Class

public static class InnerPipeCloudwatchLogsLogDestinationFactoryExtensions
{
}
