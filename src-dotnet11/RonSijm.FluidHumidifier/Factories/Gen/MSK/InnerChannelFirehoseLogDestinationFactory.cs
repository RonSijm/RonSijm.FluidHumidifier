// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelFirehoseLogDestinationFactory(Action<Humidifier.MSK.ChannelTypes.FirehoseLogDestination> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.FirehoseLogDestination>
{

    protected override Humidifier.MSK.ChannelTypes.FirehoseLogDestination Create()
    {
        var firehoseLogDestinationResult = CreateFirehoseLogDestination();
        factoryAction?.Invoke(firehoseLogDestinationResult);

        return firehoseLogDestinationResult;
    }

    private Humidifier.MSK.ChannelTypes.FirehoseLogDestination CreateFirehoseLogDestination()
    {
        var firehoseLogDestinationResult = new Humidifier.MSK.ChannelTypes.FirehoseLogDestination();

        return firehoseLogDestinationResult;
    }

} // End Of Class

public static class InnerChannelFirehoseLogDestinationFactoryExtensions
{
}
