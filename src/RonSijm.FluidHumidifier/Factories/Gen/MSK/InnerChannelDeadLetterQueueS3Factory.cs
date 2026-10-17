// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.MSK;

public class InnerChannelDeadLetterQueueS3Factory(Action<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3> factoryAction = null) : SubResourceFactory<Humidifier.MSK.ChannelTypes.DeadLetterQueueS3>
{

    protected override Humidifier.MSK.ChannelTypes.DeadLetterQueueS3 Create()
    {
        var deadLetterQueueS3Result = CreateDeadLetterQueueS3();
        factoryAction?.Invoke(deadLetterQueueS3Result);

        return deadLetterQueueS3Result;
    }

    private Humidifier.MSK.ChannelTypes.DeadLetterQueueS3 CreateDeadLetterQueueS3()
    {
        var deadLetterQueueS3Result = new Humidifier.MSK.ChannelTypes.DeadLetterQueueS3();

        return deadLetterQueueS3Result;
    }

} // End Of Class

public static class InnerChannelDeadLetterQueueS3FactoryExtensions
{
}
