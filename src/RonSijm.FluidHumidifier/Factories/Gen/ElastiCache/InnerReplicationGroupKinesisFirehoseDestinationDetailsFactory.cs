// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerReplicationGroupKinesisFirehoseDestinationDetailsFactory(Action<Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails>
{

    protected override Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails Create()
    {
        var kinesisFirehoseDestinationDetailsResult = CreateKinesisFirehoseDestinationDetails();
        factoryAction?.Invoke(kinesisFirehoseDestinationDetailsResult);

        return kinesisFirehoseDestinationDetailsResult;
    }

    private Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails CreateKinesisFirehoseDestinationDetails()
    {
        var kinesisFirehoseDestinationDetailsResult = new Humidifier.ElastiCache.ReplicationGroupTypes.KinesisFirehoseDestinationDetails();

        return kinesisFirehoseDestinationDetailsResult;
    }

} // End Of Class

public static class InnerReplicationGroupKinesisFirehoseDestinationDetailsFactoryExtensions
{
}
