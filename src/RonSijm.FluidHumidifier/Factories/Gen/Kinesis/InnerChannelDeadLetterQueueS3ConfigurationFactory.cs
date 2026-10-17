// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.Kinesis;

public class InnerChannelDeadLetterQueueS3ConfigurationFactory(Action<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration> factoryAction = null) : SubResourceFactory<Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration>
{

    protected override Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration Create()
    {
        var deadLetterQueueS3ConfigurationResult = CreateDeadLetterQueueS3Configuration();
        factoryAction?.Invoke(deadLetterQueueS3ConfigurationResult);

        return deadLetterQueueS3ConfigurationResult;
    }

    private Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration CreateDeadLetterQueueS3Configuration()
    {
        var deadLetterQueueS3ConfigurationResult = new Humidifier.Kinesis.ChannelTypes.DeadLetterQueueS3Configuration();

        return deadLetterQueueS3ConfigurationResult;
    }

} // End Of Class

public static class InnerChannelDeadLetterQueueS3ConfigurationFactoryExtensions
{
}
