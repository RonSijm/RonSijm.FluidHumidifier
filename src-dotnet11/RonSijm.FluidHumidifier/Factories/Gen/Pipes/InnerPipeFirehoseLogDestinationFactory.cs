// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Pipes;

public class InnerPipeFirehoseLogDestinationFactory(Action<Humidifier.Pipes.PipeTypes.FirehoseLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.Pipes.PipeTypes.FirehoseLogDestination>
{

    protected override Humidifier.Pipes.PipeTypes.FirehoseLogDestination Create()
    {
        var firehoseLogDestinationResult = CreateFirehoseLogDestination();
        factoryAction?.Invoke(firehoseLogDestinationResult);

        return firehoseLogDestinationResult;
    }

    private Humidifier.Pipes.PipeTypes.FirehoseLogDestination CreateFirehoseLogDestination()
    {
        var firehoseLogDestinationResult = new Humidifier.Pipes.PipeTypes.FirehoseLogDestination();

        return firehoseLogDestinationResult;
    }

} // End Of Class

public static class InnerPipeFirehoseLogDestinationFactoryExtensions
{
}
