// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class StreamConsumerFactory(string resourceName = null, Action<Humidifier.Kinesis.StreamConsumer> factoryAction = null) : ResourceFactory<Humidifier.Kinesis.StreamConsumer>(resourceName)
{

    protected override Humidifier.Kinesis.StreamConsumer Create()
    {
        var streamConsumerResult = CreateStreamConsumer();
        factoryAction?.Invoke(streamConsumerResult);

        return streamConsumerResult;
    }

    private Humidifier.Kinesis.StreamConsumer CreateStreamConsumer()
    {
        var streamConsumerResult = new Humidifier.Kinesis.StreamConsumer
        {
            GivenName = InputResourceName,
        };

        return streamConsumerResult;
    }

} // End Of Class

public static class StreamConsumerFactoryExtensions
{
}
