// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantNameQualifier

namespace RonSijm.FluidHumidifier.Factories.ElastiCache;

public class InnerCacheClusterKinesisFirehoseDestinationDetailsFactory(Action<Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails> factoryAction = null) : SubResourceFactory<Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails>
{

    protected override Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails Create()
    {
        var kinesisFirehoseDestinationDetailsResult = CreateKinesisFirehoseDestinationDetails();
        factoryAction?.Invoke(kinesisFirehoseDestinationDetailsResult);

        return kinesisFirehoseDestinationDetailsResult;
    }

    private Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails CreateKinesisFirehoseDestinationDetails()
    {
        var kinesisFirehoseDestinationDetailsResult = new Humidifier.ElastiCache.CacheClusterTypes.KinesisFirehoseDestinationDetails();

        return kinesisFirehoseDestinationDetailsResult;
    }

} // End Of Class

public static class InnerCacheClusterKinesisFirehoseDestinationDetailsFactoryExtensions
{
}
